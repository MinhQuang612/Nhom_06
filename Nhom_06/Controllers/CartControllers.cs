using Microsoft.AspNetCore.Mvc;

namespace Nhom_06.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
