using FW.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FW.Web.UI.DataAccess;
using FW.Web.UI.ViewModels;

namespace FW.Web.UI.BusinessLayer
{
    public class EmployeeLogic
    {
        private List<Employee> GetEmployees()
        {
            List<Employee> _employeeList = new List<Employee>();
            Motor_DevEntities entities = new Motor_DevEntities();
            var employees = entities.tblEmployees;
            if (employees != null)
            {
                AutoMapper.Mapper.CreateMap<tblEmployee, Employee>();

                foreach (var e in employees)
                {
                    Employee emp = AutoMapper.Mapper.Map<tblEmployee, Employee>(e);
                    _employeeList.Add(emp);
                }
            }

            return _employeeList;
        }

        public ListEmployeeViewModel GetEmployeeDetails()
        {
            List<EmployeeViewModel> _EmpViewModel = new List<EmployeeViewModel>();
            List<Employee> EmpList = GetEmployees();

            if (EmpList != null)
            {
                foreach (Employee e in EmpList)
                {
                    EmployeeViewModel VM = new EmployeeViewModel();

                    VM.EmployeeId = e.EmployeeId;
                    VM.EmployeeName = e.FirstName + " " + e.LastName;
                    VM.Salary = e.Salary.ToString("C");

                    if (e.Salary > 25000)
                    {
                        VM.SalaryColor = "#EA4335";
                    }
                    else
                    {
                        VM.SalaryColor = "#FBBC05";
                    }

                    _EmpViewModel.Add(VM);
                }
            }

            ListEmployeeViewModel listEmpDetails = new ListEmployeeViewModel();
            listEmpDetails.ListEmployee = _EmpViewModel;
            listEmpDetails.UserName = "admin";

            return listEmpDetails;
        }

        public void SaveEmployee(Employee e)
        {
            Motor_DevEntities entities = new Motor_DevEntities();

            AutoMapper.Mapper.CreateMap<Employee, tblEmployee>();

            tblEmployee t = AutoMapper.Mapper.Map<Employee, tblEmployee>(e);

            if (t != null)
            {
                entities.tblEmployees.Add(t);
                entities.SaveChanges();
            }
        }
    }
}