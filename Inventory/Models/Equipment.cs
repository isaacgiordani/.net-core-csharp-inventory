using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Equipment
    {
        [Key]
        [Display(Name = "ID")]
        public int EquipmentId { get; set; }

        [Display(Name = "Tipo de Equipamento")]
        public virtual EquipmentType EquipmentType { get; set; }

        [Display(Name = "ID Tipo de Equipamento")]
        public int EquipmentTypeId { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [Display(Name = "Patrimônio")]
        public long Equity { get; set; }

        [Display(Name = "Patrimônio Antigo")]
        public long? OldEquity { get; set; }

        [Display(Name = "Hostname")]
        public string Hostname { get; set; }

        [Display(Name = "Hostname Antigo")]
        public string OldHostname { get; set; }

        public string MAC { get; set; }

        public string IP { get; set; }

        [Display(Name = "Memória")]
        public string MEM { get; set; }

        [Display(Name = "Processador")]
        public string Processor { get; set; }

        [Display(Name = "Capacidade do HD")]
        public string HD { get; set; }

        [Display(Name = "Placa de Vídeo")]
        public string GPU { get; set; }        

        public string ServiceTag { get; set; }

        public string SerialNumber { get; set; }

        [Display(Name = "Garantia até")]
        [DataType(DataType.Date)]
        public DateTime? Warranty { get; set; }

        [Display(Name = "Última Manutenção")]
        [DataType(DataType.Date)]
        public DateTime? Maintenance { get; set; }

        [Display(Name = "Observações")]
        [MaxLength(300, ErrorMessage = "O campo suporta no máximo {0} caracteres")]
        public string Note { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; } = true;

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Registration { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime LastUpdate { get; set; }

        [Display(Name = "Colaborador")]
        public virtual Employee Employee { get; set; }
        
        [Display(Name = "ID Colaborador")]
        public int EmployeeId { get; set; }        

        public Equipment() 
        { 
        }

        public Equipment(int equipmentId, EquipmentType equipmentType, int equipmentTypeId, long equity, long? oldEquity, string hostname, string oldHostname, string mac, string ip, string mem, string processor, string hd, string gpu, string serviceTag, string serialNumber, DateTime? warranty, DateTime? maintenance, string note, bool active, DateTime registration, DateTime lastUpdate, Employee employee, int employeeId)
        {
            EquipmentId = equipmentId;
            EquipmentType = equipmentType;
            EquipmentTypeId = equipmentTypeId;
            Equity = equity;
            OldEquity = oldEquity;
            Hostname = hostname;
            OldHostname = oldHostname;
            MAC = mac;
            IP = ip;
            MEM = mem;
            Processor = processor;
            HD = hd;
            GPU = gpu;
            ServiceTag = serviceTag;
            SerialNumber = serialNumber;
            Warranty = warranty;
            Maintenance = maintenance;
            Note = note;
            Active = active;
            Registration = registration;
            LastUpdate = lastUpdate;
            Employee = employee;
            EmployeeId = employeeId;
        }
    }
}
