using Microsoft.AspNetCore.Mvc;

namespace AspAssignment.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
