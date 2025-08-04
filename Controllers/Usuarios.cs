using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    public class Usuarios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
