using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Inventory.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _equipmentService.FindById(id.Value);
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
            _equipmentService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _equipmentService.FindById(id.Value);
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

            var obj = _equipmentService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Employee> employees = _employeeService.FindAll();
            EquipmentFormViewModel viewModel = new EquipmentFormViewModel { Equipment = obj, Employees = employees };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Equipment equipment)
        {
            if (id != equipment.EquipmentId)
            {
                return BadRequest();
            }

            try
            {
                _equipmentService.Update(equipment);
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
