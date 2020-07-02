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
        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage ="O campo {0} deve possuir entre {2} e {1} caracteres")]
        public string Name { get; set; }

        [RegularExpression(@"^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$",
        ErrorMessage = "O CNPJ deve estar no formato 00.000.000/0000-00")]
        public string CNPJ { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; } = true;

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Registration { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime LastUpdate { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public Company()
        {
        }

        public Company(int companyId, string name, string cnpj, bool active, DateTime registration, DateTime lastUpdate)
        {
            CompanyId = companyId;
            Name = name;
            CNPJ = cnpj;
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
