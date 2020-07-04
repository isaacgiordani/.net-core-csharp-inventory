using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Models.ViewModels
{
    public class EquipmentTypeFormViewModel
    {
        public EquipmentType EquipmentType { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
    }
}
