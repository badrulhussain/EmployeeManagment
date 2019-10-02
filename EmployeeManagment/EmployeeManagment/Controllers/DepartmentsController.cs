using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Controllers
{
    [Route("[controller]")]
    public class DepartmentsController : Controller
    {
        [Route("[action]")]
        [Route("")] // Makes List(), the default action

        public string List()
        {
            return "List() of DepartmentsController";
        }

        [Route("[action]")]
        public string Details()
        {
            return "Details() of DepartmentsController";
        }
    }
}
