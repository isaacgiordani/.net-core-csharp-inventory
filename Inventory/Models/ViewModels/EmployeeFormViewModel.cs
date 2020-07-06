using System.Collections.Generic;

namespace Inventory.Models.ViewModels
{
    public class EmployeeFormViewModel
    {
        public Employee Employee { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
    }
}
