using FW.Web.UI.BusinessLayer;
using FW.Web.UI.Models;
using FW.Web.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FW.Web.UI.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            EmployeeLogic logic = new EmployeeLogic();
            ListEmployeeViewModel  EM = logic.GetEmployeeDetails();
            return View(EM);
        }

        public ActionResult AddNew()
        {
            return View();
        }

        public ActionResult SaveEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {
                EmployeeLogic logic = new EmployeeLogic();
                logic.SaveEmployee(e);

                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View("AddNew");
            }
        }
    }
}
