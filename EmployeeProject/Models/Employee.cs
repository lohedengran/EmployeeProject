using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Display(Name = "Name: ")]
        [Required(ErrorMessage ="Enter a name")]
        public string Name { get; set; }

        [Display(Name = "E-mail: ")]
        [EmailAddress]
        [Required(ErrorMessage = "Enter a valid e-mail")]
        public string Email { get; set; }
    }
}
