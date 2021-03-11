using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeProject.Models;

namespace EmployeeProject.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeService service = new EmployeeService();

        [Route("")]
        [Route("employees/index")]
        public IActionResult Index()
        {
            var employees = service.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            service.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
