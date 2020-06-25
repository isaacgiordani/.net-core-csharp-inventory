using Inventory.Data;
using Inventory.Models;
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
            //if(obj.Active == false) { obj.Active = true; }
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
