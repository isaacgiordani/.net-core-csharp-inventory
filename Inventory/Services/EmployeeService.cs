using Inventory.Data;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Employee FindById(int id)
        {
            return _context.Employee.Include(obj => obj.Company).FirstOrDefault(obj => obj.EmployeeId == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Employee.Find(id);
            _context.Employee.Remove(obj);
            _context.SaveChanges();
        }
    }
}
