using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACLens.Programming.Examination.Senior
{
    interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetLongestServingEmployee(IEnumerable<Employee> employees)
    }
   public class EmployeeService : IEmployeeService
    {
    public IEnumerable<Employee> GetAllEmployees()
{
 	throw new NotImplementedException();
}

public Employee GetLongestServingEmployee(IEnumerable<Employee> employees)
{
 	throw new NotImplementedException();
}
}
}
