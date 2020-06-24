using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class EquipmentsController : Controller
    {
        private readonly EquipmentService _equipmentService;
        private readonly EmployeeService _employeeService;

        public EquipmentsController(EquipmentService equipmentService, EmployeeService employeeService)
        {
            _equipmentService = equipmentService;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var list = _equipmentService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var employees = _employeeService.FindAll();
            var viewModel = new EquipmentFormViewModel { Employees = employees };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Equipment equipment)
        {
            _equipmentService.Insert(equipment);
            return RedirectToAction(nameof(Index));
        }
    }
}
