using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class EquipmentType
    {
        public int EquipmentTypeId { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir entre {2} e {1} caracteres")]
        [Display(Name = "Tipo")]
        public string Type { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir entre {2} e {1} caracteres")]
        [Display(Name = "Fabricante")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido.")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "O campo {0} deve possuir entre {2} e {1} caracteres")]
        [Display(Name = "Modelo")]
        public string Model { get; set; }

        [Display(Name = "Tipo de Equipamento")]
        public string Info
        {
            get { return string.Format("{0} {1} {2}", Type, Manufacturer, Model); }            
        }

        public ICollection<Equipment> Equipments { get; set; } = new List<Equipment>();

        public EquipmentType()
        {
        }

        public EquipmentType(int equipmentTypeId, string type, string manufacturer, string model)
        {
            EquipmentTypeId = equipmentTypeId;
            Type = type;
            Manufacturer = manufacturer;
            Model = model;
        }
    }
}
