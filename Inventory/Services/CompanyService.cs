using Inventory.Data;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Services
{
    public class CompanyService
    {
        private readonly ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Company> FindAll()
        //public async Task<IActionResult> FindAllAsync()
        {
            return _context.Company.OrderBy(x => x.Name).ToList();
            //return View(await _context.Company.ToListAsync());
        }

        public void Insert(Company obj)
        {
            //if(obj.Active == false) { obj.Active = true; }
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Company FindById(int id)
        {            
            return _context.Company.FirstOrDefault(obj => obj.CompanyId == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Company.Find(id);
            _context.Company.Remove(obj);
            _context.SaveChanges();
        }
    }
}
