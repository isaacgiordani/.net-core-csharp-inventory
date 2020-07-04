using Inventory.Models;
using Inventory.Models.ViewModels;
using Inventory.Services;
using Inventory.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    public class EquipmentTypesController : Controller
    {
        private readonly EquipmentTypeService _equipmentTypeService;
        public EquipmentTypesController(EquipmentTypeService equipmentTypeService)
        {
            _equipmentTypeService = equipmentTypeService;           
        }
        
        public async Task<IActionResult> Index()
        {
            var list = await _equipmentTypeService.FindAllAsync();
            return View(list);            
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            EquipmentType equipmentType = await _equipmentTypeService.FindByIdAsync(id.Value);
            if (equipmentType == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }

            return View(equipmentType);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EquipmentType equipmentType)
        {
            if (!ModelState.IsValid)
            {                
                return View(equipmentType);
            }
            await _equipmentTypeService.InsertAsync(equipmentType);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var equipmentType = await _equipmentTypeService.FindByIdAsync(id.Value);
            if (equipmentType == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }            

            return View(equipmentType);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EquipmentType equipmentType)
        {
            if (!ModelState.IsValid)
            {
                return View(equipmentType);
            }

            if (id != equipmentType.EquipmentTypeId)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não correspondente." });
            }

            try
            {
                await _equipmentTypeService.UpdateAsync(equipmentType);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido." });
            }

            var equipmentType = await _equipmentTypeService.FindByIdAsync(id.Value);
            if (equipmentType == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado." });
            }
            return View(equipmentType);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _equipmentTypeService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException)
            {
                return RedirectToAction(nameof(Error), new { message = "Não foi possível excluir o registro, pois ele possui relacionamento(s) com outra(s) tabela(s). " });
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
    }
}
