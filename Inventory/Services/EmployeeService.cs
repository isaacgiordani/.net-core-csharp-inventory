using Inventory.Data;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Employee> FindAll()
        //public async Task<IActionResult> FindAllAsync()
        {
            return _context.Employee.OrderBy(x => x.Name).ToList();
            //return View(await _context.Company.ToListAsync());
        }

        public void Insert(Employee obj)
        {
            //if(obj.Active == false) { obj.Active = true; }
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
