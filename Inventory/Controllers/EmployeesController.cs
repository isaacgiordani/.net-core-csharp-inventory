using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Inventory.Services.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly EmployeeService _employeeService;
        private readonly CompanyService _companyService;

        public EmployeesController(EmployeeService employeeService, CompanyService companyService)
        {
            _employeeService = employeeService;
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _employeeService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var companies = await _companyService.FindAllAsync();
            var viewModel = new EmployeeFormViewModel { Companies = companies };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                var companies = await _companyService.FindAllAsync();
                var viewModel = new EmployeeFormViewModel { Employee = employee, Companies = companies };
                return View(viewModel);
            }

            employee.Name = employee.Name.ToUpper().Trim();
            employee.Email = employee.Email.ToLower().Trim();
            if (employee.ExternEmail != null)
            {
                employee.ExternEmail = employee.ExternEmail.ToLower().Trim();
            }            
            employee.Active = true;
            employee.LastUpdate = DateTime.Now;
            employee.Registration = DateTime.Now;

            await _employeeService.InsertAsync(employee);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _employeeService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _employeeService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException)
            {
                return RedirectToAction(nameof(Error), new { message = "Não foi possível excluir o registro, pois ele possui relacionamento(s) com outra(s) tabela(s). "});
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _employeeService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _employeeService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }

            List<Company> companies = await _companyService.FindAllAsync();
            EmployeeFormViewModel viewModel = new EmployeeFormViewModel { Employee = obj, Companies = companies };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                var companies = await _companyService.FindAllAsync();
                var viewModel = new EmployeeFormViewModel { Employee = employee, Companies = companies };
                return View(employee);
            }

            if (id != employee.EmployeeId)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não correspondente." });
            }

            try
            {
                employee.Name = employee.Name.ToUpper().Trim();
                employee.Email = employee.Email.ToLower().Trim();
                if (employee.ExternEmail != null)
                {
                    employee.ExternEmail = employee.ExternEmail.ToLower().Trim();
                }
                employee.LastUpdate = DateTime.Now;

                await _employeeService.UpdateAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

        public async Task<IActionResult> EquipmentsByEmployee(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _employeeService.EquipmentsByEmployeeAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }
                        
            return View(obj);
        }
    }
}
