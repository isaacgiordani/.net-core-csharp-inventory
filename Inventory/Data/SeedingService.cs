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

            Company C1 = new Company(1, "BRASIL TESTE LTDA","BRASIL","01.171.999/0005-11",true,DateTime.Now,DateTime.Now);

            Employee E1 = new Employee(1, "12345", "ISAAC GIORDANI DA ROCHA", "isaacgiordani@gmail.com", "", "202020-6", "1236547896", true, DateTime.Now, DateTime.Now, C1);
            
            EquipmentType EqtT1 = new EquipmentType(1,"CELULAR","SAMSUNG","J6");

            Equipment Ept1 = new Equipment(1,EqtT1,EqtT1.EquipmentTypeId,15,0, "FLA-MEN-GO-0021", null,null,null,"4GB","i5-3340M","500GB","I HD G 4000","XXQYX1","1234257621",null, new DateTime(2020, 06, 23),"TESTANDO SEEDING",true,DateTime.Now,DateTime.Now,E1,E1.EmployeeId);


            _context.Company.AddRange(C1);
            _context.Employee.AddRange(E1);
            _context.EquipmentType.AddRange(EqtT1);
            _context.Equipment.AddRange(Ept1);

            _context.SaveChanges();
        }
    }
}
