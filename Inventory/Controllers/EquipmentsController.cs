using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Inventory.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Index()
        {
            var list = await _equipmentService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var employees = await _employeeService.FindAllAsync();
            var viewModel = new EquipmentFormViewModel { Employees = employees };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Equipment equipment)
        {
            if (!ModelState.IsValid)
            {
                var employees = await _employeeService.FindAllAsync();
                var viewModel = new EquipmentFormViewModel { Equipment = equipment, Employees = employees };
                return View(viewModel);
            }

            equipment.Active = true;
            equipment.LastUpdate = DateTime.Now;
            equipment.Registration = DateTime.Now;

            await _equipmentService.InsertAsync(equipment);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _equipmentService.FindByIdAsync(id.Value);
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
                await _equipmentService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException)
            {
                return RedirectToAction(nameof(Error), new { message = "Não foi possível excluir o registro, pois ele possui relacionamento(s) com outra(s) tabela(s). " });
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _equipmentService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }
            var obj2 = await _employeeService.FindAllAsync();
            EquipmentFormViewModel viewModel = new EquipmentFormViewModel { Equipment = obj, Employees = obj2 };
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var obj = await _equipmentService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }

            List<Employee> employees = await _employeeService.FindAllAsync();
            EquipmentFormViewModel viewModel = new EquipmentFormViewModel { Equipment = obj, Employees = employees };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Equipment equipment)
        {
            if (!ModelState.IsValid)
            {
                var employees = await _employeeService.FindAllAsync();
                var viewModel = new EquipmentFormViewModel { Equipment = equipment, Employees = employees };
                return View(viewModel);
            }

            if (id != equipment.EquipmentId)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não correspondente." });
            }

            try
            {
                equipment.LastUpdate = DateTime.Now;

                await _equipmentService.UpdateAsync(equipment);
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

        public async Task<IActionResult> EquipmentsUnderWarranty()
        {
            var result = await _equipmentService.EquipmentsUnderWarrantyAsync();
            return View(result);
        }
    }
}
