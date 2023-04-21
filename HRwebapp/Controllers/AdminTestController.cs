using Microsoft.AspNetCore.Mvc;

namespace HRwebapp.Controllers
{
    public class AdminTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
