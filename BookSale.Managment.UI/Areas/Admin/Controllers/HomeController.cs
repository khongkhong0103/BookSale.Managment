using Microsoft.AspNetCore.Mvc;

namespace BookSale.Managment.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
