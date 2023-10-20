using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Yönetim
{
    public class YönetimPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
