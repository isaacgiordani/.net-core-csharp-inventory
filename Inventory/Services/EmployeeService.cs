using Inventory.Data;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Inventory.Services.Exceptions;

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

        public void Update(Employee employee)
        {
            if (!_context.Employee.Any(obj => obj.EmployeeId == employee.EmployeeId))
            {
                throw new NotFoundException("ID não encontrado!");
            }
            try
            {
                _context.Update(employee);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao atualizar o registro: " + e.Message);
            }
        }
    }
}
