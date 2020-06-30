using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Inventory.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "ID")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [MaxLength(8, ErrorMessage = "O campo suporta no máximo {0} caracteres")]
        [Display(Name = "Matrícula")]
        public string Enrollment { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [MaxLength(60, ErrorMessage = "O campo suporta no máximo {0} caracteres")]
        [Display(Name = "Colaborador")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail Secundário")]
        public string ExternEmail { get; set; }

        [MaxLength(20, ErrorMessage = "O campo suporta no máximo {0} caracteres")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [MaxLength(14, ErrorMessage = "O campo suporta no máximo {0} caracteres")]
        public string CPF { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; } = true;

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Registration { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime LastUpdate { get; set; }
        
        [Display(Name = "Empresa")]
        public virtual Company Company { get; set; }

        [Display(Name = "Empresa")]
        public int CompanyId { get; set; }

        public ICollection<Equipment> Equipments { get; set; } = new List<Equipment>();

        public Employee ()
        {
        }

        public Employee(int employeeId, string enrollment, string name, string email, string externEmail, string rg, string cpf, bool active, DateTime registration, DateTime lastUpdate, Company company)
        {
            EmployeeId = employeeId;
            Enrollment = enrollment;
            Name = name;
            Email = email;
            ExternEmail = externEmail;
            RG = rg;
            CPF = cpf;
            Active = active;
            Registration = registration;
            LastUpdate = lastUpdate;
            Company = company;
        }

        public void AddEquipment(Equipment e)
        {
            Equipments.Add(e);
        }

        public void RemoveEquipment(Equipment e)
        {
            Equipments.Remove(e);
        }

        public int TotalActiveEquipment() 
        {
            return Equipments.Where(e => e.Active == true).Count();
        }
        public int TotalInactiveEquipment()
        {
            return Equipments.Where(e => e.Active == false).Count();
        }

        public int TotalUnderWarranty()
        {
            return Equipments.Where(e => e.Warranty >= DateTime.Now).Count();
        }

        public int TotalOutOfWarranty()
        {
            return Equipments.Where(e => e.Warranty <= DateTime.Now).Count();
        }
    }
}