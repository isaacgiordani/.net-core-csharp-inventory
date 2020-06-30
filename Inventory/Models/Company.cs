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

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Registration { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime LastUpdate { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public Company()
        {
        }

        public Company(int companyId, string name, string cNPJ, bool active, DateTime registration, DateTime lastUpdate)
        {
            CompanyId = companyId;
            Name = name;
            CNPJ = cNPJ;
            Active = active;
            Registration = registration;
            LastUpdate = lastUpdate;
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
