using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FW.Web.UI.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; set; }
    }
}