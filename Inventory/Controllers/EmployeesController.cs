using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeService _employeeService;
        private readonly CompanyService _companyService;

        public EmployeesController(EmployeeService employeeService, CompanyService companyService)
        {
            _employeeService = employeeService;
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var list = _employeeService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var companies = _companyService.FindAll();
            var viewModel = new EmployeeFormViewModel { Companies = companies };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            _employeeService.Insert(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
