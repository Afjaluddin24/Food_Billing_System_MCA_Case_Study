using Microsoft.AspNetCore.Mvc;

namespace Food_Bill_Sustem.Controllers
{
    public class AdminController : Controller
    {

        [Route("Admin/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Admin/Category")]
        public IActionResult Category()
        {
            return View();
        }

        [Route("Admin/FoodItems")]
        public IActionResult FoodItems()
        {
            return View();
        }


        [Route("Admin/Orders")]
        public IActionResult Orders()
        {
            return View();
        }

        [Route("Admin/OrdersDetals")]
        public IActionResult OrdersDetals()
        {
            return View();
        }

        [Route("Admin/Invoice")]
        public IActionResult Invoice(string BillName)
        {
            ViewBag.Name = BillName;
            return View();
        }
    }
}
