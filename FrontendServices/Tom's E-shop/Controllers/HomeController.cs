using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Tom_s_E_shop.HttpClients;
using Tom_s_E_shop.Models;

namespace Tom_s_E_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly CatalogServiceClient _catalogServiceClient;
        public HomeController(CatalogServiceClient catalogServiceClient)
        {
            _catalogServiceClient = catalogServiceClient;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _catalogServiceClient.GetProductsAsync();
            return View(products);
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
