using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Inventory.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _employeeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _employeeService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _employeeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _employeeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Company> companies = _companyService.FindAll();
            EmployeeFormViewModel viewModel = new EmployeeFormViewModel { Employee = obj, Companies = companies };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            try
            {
                _employeeService.Update(employee);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
