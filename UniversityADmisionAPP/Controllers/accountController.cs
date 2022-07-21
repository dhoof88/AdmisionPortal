using Microsoft.AspNetCore.Mvc;

namespace UniversityADmisionAPP.Controllers
{
    public class accountController : Controller
    {
        public IActionResult sigin()
        {
            return View();
        }
        public IActionResult forget()
        {
            return View();
        }
    }
}
