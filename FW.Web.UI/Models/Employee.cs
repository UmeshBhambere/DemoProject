using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FW.Web.UI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        
        [FirstNameValidation]
        public string FirstName { get; set; }

        [MinLength(3), MaxLength(50), Required(ErrorMessage = "Please enter last name"), StringLength(50, ErrorMessage = "Please enter valid last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter salary"),RegularExpression("^[0-9]{4}$",ErrorMessage="Please enter valid salary amount")]
        public int Salary { get; set; }
    }
}