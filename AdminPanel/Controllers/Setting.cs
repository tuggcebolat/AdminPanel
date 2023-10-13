using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class Setting : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
