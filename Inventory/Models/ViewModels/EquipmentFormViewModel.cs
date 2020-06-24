using System.Collections.Generic;

namespace Inventory.Models.ViewModels
{
    public class EquipmentFormViewModel
    {
        public Equipment Equipment { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
