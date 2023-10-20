using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Yönetim
{
    public class YönetimUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
