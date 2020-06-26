using Inventory.Data;
using Inventory.Models;
using Inventory.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Services
{
    public class EquipmentService
    {
        private readonly ApplicationDbContext _context;

        public EquipmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Equipment> FindAll()
        //public async Task<IActionResult> FindAllAsync()
        {
            return _context.Equipment.OrderBy(x => x.Equity).ToList();
            //return View(await _context.Company.ToListAsync());
        }

        public void Insert(Equipment obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Equipment FindById(int id)
        {
            return _context.Equipment.Include(obj => obj.Employee).FirstOrDefault(obj => obj.EquipmentId == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Equipment.Find(id);
            _context.Equipment.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Equipment equipment)
        {
            if (!_context.Equipment.Any(obj => obj.EquipmentId == equipment.EquipmentId))
            {
                throw new NotFoundException("ID não encontrado!");
            }
            try
            {
                _context.Update(equipment);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao atualizar o registro: " + e.Message);
            }
        }
    }
}
