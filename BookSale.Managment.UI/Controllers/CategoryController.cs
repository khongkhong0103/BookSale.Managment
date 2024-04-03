using Microsoft.AspNetCore.Mvc;

namespace BookSale.Managment.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
