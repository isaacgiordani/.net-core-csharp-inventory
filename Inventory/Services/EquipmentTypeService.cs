using Inventory.Data;
using Inventory.Models;
using Inventory.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class EquipmentTypeService
    {
        private readonly ApplicationDbContext _context;

        public EquipmentTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<EquipmentType>> FindAllAsync()
        {
            return await _context.EquipmentType.Include(obj => obj.Equipments).OrderBy(x => x.Type).ToListAsync();
        }

        public async Task InsertAsync(EquipmentType obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<EquipmentType> FindByIdAsync(int id)
        {
            return await _context.EquipmentType.Include(obj => obj.Equipments).FirstOrDefaultAsync(obj => obj.EquipmentTypeId == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.EquipmentType.FindAsync(id);
                _context.EquipmentType.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(EquipmentType EquipmentType)
        {
            var hasAny = await _context.EquipmentType.AnyAsync(obj => obj.EquipmentTypeId == EquipmentType.EquipmentTypeId);
            if (!hasAny)
            {
                throw new NotFoundException("ID não encontrado!");
            }
            try
            {
                _context.Update(EquipmentType);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao atualizar o registro: " + e.Message);
            }
        }        
    }
}
