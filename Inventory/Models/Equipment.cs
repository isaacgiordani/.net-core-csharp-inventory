using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Equipment
    {
        [Key]
        [Display(Name = "ID")]
        public int EquipmentId { get; set; }

        //[Display(Name = "Empresa")]
        //public int CompanyId { get; set; }
        //public virtual Company Company { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [Display(Name = "Patrimônio")]
        public long Equity { get; set; }

        [Display(Name = "Patrimônio Antigo")]
        public long OldEquity { get; set; }

        //[Display(Name = "Colaborador")]
        //public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }

        public string Hostname { get; set; }

        [Display(Name = "Hostname Antigo")]
        public string OldHostname { get; set; }

        //[Display(Name = "Tipo")]
        //public int EquipmentTypeId { get; set; }
        //public virtual EquipmentType EquipmentType { get; set; }

        public string MAC { get; set; }

        public string IP { get; set; }

        //public int PlaceId { get; set; }
        //public virtual Place Place { get; set; }

        //[Display(Name = "Departamento")]
        //public string Department { get; set; }

        [Display(Name = "Memória")]
        public string MEM { get; set; }

        [Display(Name = "Processador")]
        public string Processor { get; set; }

        [Display(Name = "Capacidade do HD")]
        public string HD { get; set; }

        [Display(Name = "Placa de Vídeo")]
        public string GPU { get; set; }

        [Display(Name = "Fabricante")]
        public string Manufacturer { get; set; }

        [Display(Name = "Modelo")]
        public string Model { get; set; }

        public string ServiceTag { get; set; }

        public string SerialNumber { get; set; }

        [Display(Name = "Data da Manutenção")]
        public DateTime? Maintenance { get; set; }

        [Display(Name = "Garantia expira em")]
        public DateTime? Warranty { get; set; }

        [Display(Name = "Última Atualização")]
        public DateTime LastUpdate { get; set; }

        [Display(Name = "Observações")]
        public string Note { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; } = true;
    }
}
