using CompanySystem.PL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CompanySystem.PL.Controllers
{
    public class DepartmentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crate(CreateDepartmentDto  dto)
        {
            if(ModelState.IsValid)
            {

            }

            return View();
        }
    }
}
