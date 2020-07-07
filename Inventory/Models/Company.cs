using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "ID")]
        public int CompanyId { get; set; }

        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "O campo {0} deve possuir entre {2} e {1} caracteres")]
        public string CompanyName { get; set; }

        [Display(Name = "Fantasia")]
        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir entre {2} e {1} caracteres")]
        public string FantasyName { get; set; }

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

        public Company(int companyId, string companyName, string fantasyName, string cnpj, bool active, DateTime registration, DateTime lastUpdate)
        {
            CompanyId = companyId;
            CompanyName = companyName;
            FantasyName = fantasyName;
            CNPJ = cnpj;
            Active = active;
            Registration = registration;
            LastUpdate = lastUpdate;
        }
    }
}
