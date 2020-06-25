using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Inventory.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "ID")]
        public int CompanyId { get; set; }

        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "O campo é requerido.")]
        public string Name { get; set; }

        public string CNPJ { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; } = true;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public Company()
        {
        }

        public Company(int companyId, string name, string cnpj, bool active)
        {
            CompanyId = companyId;
            Name = name;
            CNPJ = cnpj;
            Active = active;
        }

        public void AddEmployee(Employee employee) 
        {
            Employees.Add(employee);
        }

        public int TotalActiveEquipments()
        {
            return Employees.Sum(employee => employee.TotalActiveEquipment());
        }

        public int TotalInactiveEquipments()
        {
            return Employees.Sum(employee => employee.TotalInactiveEquipment());
        }
    }
}
