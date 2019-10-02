using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Model
{
    public interface IEmployeeRepository
    {
        Employee GetById(int Id);

        List<Employee> GetAll();
    }
}
