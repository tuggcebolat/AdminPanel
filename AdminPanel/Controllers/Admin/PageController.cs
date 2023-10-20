using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
