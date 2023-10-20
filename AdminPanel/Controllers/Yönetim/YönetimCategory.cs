using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Yönetim
{
    public class YönetimCategory : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
