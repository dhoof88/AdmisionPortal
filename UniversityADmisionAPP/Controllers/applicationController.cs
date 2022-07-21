using Microsoft.AspNetCore.Mvc;

namespace UniversityADmisionAPP.Controllers
{
    public class applicationController : Controller
    {
        public IActionResult process()
        {
            return View();
        }
        public IActionResult appli()
        {
            return View();
        }
    }
}
