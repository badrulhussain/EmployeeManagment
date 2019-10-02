using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Model;
using EmployeeManagment.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagment.Controllers
{
        [Route("Home")]
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: /<controller>/
        [Route("/")]
        [Route("")]
        [Route("Index")]
        public ActionResult Index()
        {
            return View(_employeeRepository.GetAll());
        }

        [Route("Details/{Id?}")]
        public ActionResult Details(int? Id)
        {

            var EmployeeModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetById(Id??1),
                PageTitle = "Details Page"
            };

            return View(EmployeeModel);
        }

        public JsonResult DetailsJson()
        {
            var EmployeeModel = _employeeRepository.GetById(1);

            return Json(EmployeeModel);
        }

        public ActionResult DetailsFromOtherDir()
        {
            var EmployeeModel = _employeeRepository.GetById(1);

            return View("MyViews/Test.cshtml");
        }

        public ActionResult DetailsFromLevelDir()
        {
            var EmployeeModel = _employeeRepository.GetById(1);

            return View("../Test/Update");
        }
    }
}
