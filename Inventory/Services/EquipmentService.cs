﻿using Inventory.Data;
using Inventory.Models;
using Inventory.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class EquipmentService
    {
        private readonly ApplicationDbContext _context;

        public EquipmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Equipment>> FindAllAsync()       
        {
            return await _context.Equipment.Include(obj => obj.Employee).OrderBy(x => x.Equity).ToListAsync();
        }

        public async Task InsertAsync(Equipment obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Equipment> FindByIdAsync(int id)
        {
            return await _context.Equipment.Include(obj => obj.Employee).FirstOrDefaultAsync(obj => obj.EquipmentId == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Equipment.FindAsync(id);
                _context.Equipment.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(Equipment equipment)
        {
            var hasAny = await _context.Equipment.AnyAsync(obj => obj.EquipmentId == equipment.EquipmentId);
            if (!hasAny)
            {
                throw new NotFoundException("ID não encontrado!");
            }
            try
            {
                _context.Update(equipment);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao atualizar o registro: " + e.Message);
            }
        }

        public async Task<List<Equipment>> EquipmentsUnderWarrantyAsync()
        {
            var result = from obj in _context.Equipment select obj;
            result = result.Where(x => x.Warranty >= DateTime.Today);
            return await result
                .Include(x => x.Employee)
                .Include(x => x.Employee.Company)
                .OrderByDescending(x => x.Warranty)
                .ToListAsync();
        }
    }
}
