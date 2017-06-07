using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FW.Web.UI.ViewModels
{
    public class ListEmployeeViewModel
    {
        public List<EmployeeViewModel> ListEmployee { get; set; }
        public string UserName { get; set; }
    }
}