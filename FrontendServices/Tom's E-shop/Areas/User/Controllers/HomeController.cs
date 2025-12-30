using Microsoft.AspNetCore.Mvc;

namespace Tom_s_E_shop.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
