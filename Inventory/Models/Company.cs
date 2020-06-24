using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        public string CNPJ { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; }
    }
}
