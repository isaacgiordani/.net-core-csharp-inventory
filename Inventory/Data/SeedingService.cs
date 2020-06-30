using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class SeedingService
    {
        private ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void Seed() 
        {
            if (_context.Company.Any() ||
                _context.Employee.Any() ||
                _context.Equipment.Any()) 
            {
                return; //DB has been seeded
            }

            Company C1 = new Company(1, "IVM Projetos",null,true,DateTime.Now,DateTime.Now);
            Employee E1 = new Employee(1, "S28481","Isaac Rocha","isaac.rocha@semcon.com",null,null,"112.037.867-27",true,DateTime.Now,DateTime.Now,C1);
            Equipment Ept1 = new Equipment(1,15,0,"BR-RSD-NB-0021",null,null,null,"4GB","i5-3340M","500GB","I HD G 4000","Dell","Latitude E5530","DCQZX1","2984257621",null, new DateTime(2020, 06, 23),"TESTANDO SEEDING",true,DateTime.Now,DateTime.Now,E1);

            _context.Company.AddRange(C1);
            _context.Employee.AddRange(E1);
            _context.Equipment.AddRange(Ept1);

            _context.SaveChanges();
        }
    }
}
