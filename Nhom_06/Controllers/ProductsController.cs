using Microsoft.AspNetCore.Mvc;

namespace Nhom_06.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Detail()
        {
            return View();
        }
    }
}
