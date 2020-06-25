using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Equipment
    {
        [Key]
        [Display(Name = "ID")]
        public int EquipmentId { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [Display(Name = "Patrimônio")]
        public long Equity { get; set; }

        [Display(Name = "Patrimônio Antigo")]
        public long OldEquity { get; set; }

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

        [Display(Name = "Colaborador")]
        public virtual Employee Employee { get; set; }
        
        [Display(Name = "ID Colaborador")]
        public int EmployeeId { get; set; }
        
        public Equipment() 
        { 
        }

        public Equipment(int equipmentId, long equity, long oldEquity, string hostname, string oldHostname, string mac, string ip, string mem, string processor, string hd, string gpu, string manufacturer, string model, string serviceTag, string serialNumber, DateTime? maintenance, DateTime? warranty, DateTime lastUpdate, string note, bool active, Employee employee)
        {
            EquipmentId = equipmentId;
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
            Manufacturer = manufacturer;
            Model = model;
            ServiceTag = serviceTag;
            SerialNumber = serialNumber;
            Maintenance = maintenance;
            Warranty = warranty;
            LastUpdate = lastUpdate;
            Note = note;
            Active = active;
            Employee = employee;
        }
    }
}
