using Microsoft.AspNetCore.Mvc;

namespace CompanySystem.PL.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
