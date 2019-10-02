using EmployeeManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.ViewModels
{
    public class HomeDetailsViewModel
    {
        public string PageTitle { get; set; }
        public Employee Employee { get; set; }
    }
}
