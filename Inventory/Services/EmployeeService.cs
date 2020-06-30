using Inventory.Data;
using Inventory.Models;
using Inventory.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> FindAllAsync()
        {
            return await _context.Employee.Include(obj => obj.Company).OrderBy(y => y.Name).OrderBy(x => x.Company.Name).ToListAsync();
        }

        public async Task InsertAsync(Employee obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> FindByIdAsync(int id)
        {
            return await _context.Employee.Include(obj => obj.Company).FirstOrDefaultAsync(obj => obj.EmployeeId == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            var hasAny = await _context.Employee.AnyAsync(obj => obj.EmployeeId == employee.EmployeeId);
            if (!hasAny)
            {
                throw new NotFoundException("ID não encontrado!");
            }
            try
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao atualizar o registro: " + e.Message);
            }
        }
    }
}
