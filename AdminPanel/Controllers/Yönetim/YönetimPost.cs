using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Yönetim
{
    public class YönetimPost : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
