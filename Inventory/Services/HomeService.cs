using Inventory.Data;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class HomeService
    {
        private readonly ApplicationDbContext _context;

        public HomeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AllActiveCompaniesAsync()
        {
            return await _context.Company.Where(obj => obj.Active == true).CountAsync();
        }

        public async Task<int> AllActiveEmployeesAsync()
        {
            return await _context.Employee.Where(obj => obj.Active == true).CountAsync();
        }

        public async Task<int> AllActiveEquipmentsAsync()
        {
            return await _context.Equipment.Where(obj => obj.Active == true).CountAsync();
        }
    }
}
