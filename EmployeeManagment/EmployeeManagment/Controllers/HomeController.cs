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
    public class WelcomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public WelcomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: /<controller>/
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ActionResult List()
        {
            return View("~/Views/Home/Index.cshtml", _employeeRepository.GetAll());
        }

        [Route("Home/Details/{Id?}")]
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
