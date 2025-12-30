using Microsoft.AspNetCore.Mvc;
using Tom_s_E_shop.Helper;

namespace Tom_s_E_shop.Areas.User.Controllers
{
    [CustomAuthorize(Roles = "User")]
    [Area("User")]
    public class BaseController : Controller
    {
       
    }
}
