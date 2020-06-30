using Inventory.Data;
using Inventory.Models;
using Inventory.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class CompanyService
    {
        private readonly ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Company>> FindAllAsync()
        {
            return await _context.Company.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task InsertAsync(Company obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Company> FindByIdAsync(int id)
        {            
            return await _context.Company.FirstOrDefaultAsync(obj => obj.CompanyId == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Company.FindAsync(id);
            _context.Company.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Company company)
        {
            bool hasAny = await _context.Company.AnyAsync(obj => obj.CompanyId == company.CompanyId);
            if (!hasAny)
            {
                throw new NotFoundException("ID não encontrado!");
            }
            try
            {
                _context.Update(company);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao atualizar o registro: " + e.Message);
            }
        }
    }
}
