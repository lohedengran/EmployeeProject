using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class EmployeeService
    {
        public static List<Employee> Employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public Employee[] GetAllEmployees()
        {
            return Employees.ToArray();
        }
    }
}
