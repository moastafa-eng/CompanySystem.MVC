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
        public IActionResult Create(CreateDepartmentDto  dto)
        {
            if(ModelState.IsValid)
            {

            }

            return View();
        }

        [HttpGet]
        public IActionResult Details (int? id)
        {
            return View();
        }
    }
}
