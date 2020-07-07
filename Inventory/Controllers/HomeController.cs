using Inventory.Models.ViewModels;
using Inventory.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;            
        }

        public async Task<IActionResult> Index()
        {
            var allActiveCompanies = await _homeService.AllActiveCompaniesAsync();
            var allActiveEmployees = await _homeService.AllActiveEmployeesAsync();
            var allActiveEquipments = await _homeService.AllActiveEquipmentsAsync();            
            HomeFormViewModel viewModel = new HomeFormViewModel { AllActiveCompanies = allActiveCompanies, AllActiveEmployees = allActiveEmployees, AllActiveEquipments = allActiveEquipments };
            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
