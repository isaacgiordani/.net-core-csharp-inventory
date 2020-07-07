using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Models.ViewModels
{
    public class HomeFormViewModel
    {
        [Display(Name ="Empresas Ativas")]
        public int AllActiveCompanies { get; set; }

        [Display(Name = "Colaboradores Ativos")]
        public int AllActiveEmployees { get; set; }

        [Display(Name = "Equipamentos Ativos")]
        public int AllActiveEquipments { get; set; }
    }
}
