/** =========================================================

 Andrew Snook

 Operating System: Windows 10

 Microsoft Visual Studio 2017 Enterprise

 CIS 174

 EmployeeManagement (Week 5)

 Program Description: This application allows the user to view and create database records containing employee information

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/


using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using AndrewSnook.CIS174.EmployeeManagementApp.Web.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController(IEmployeeOrchestrator employeeOrchestrator)
        {
            _employeeOrchestrator = employeeOrchestrator;
        }

        // GET: Employee
        public async Task<ActionResult> ViewAllEmployees()
        {
            var employeeDisplayModel = new EmployeeDisplayModel
            {
                Employees = await _employeeOrchestrator.GetAllEmployees()
            };

            return View(employeeDisplayModel);
        }

        public async Task<ActionResult> Create(CreateEmployeeModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
            {
                return View();
            }

            var updatedCount = await _employeeOrchestrator.CreateEmployee(new EmployeeViewModel
            {
                FirstName=employee.FirstName,
                MiddleInitial=employee.MiddleInitial,
                LastName=employee.LastName,
                HireDate=employee.HireDate,
                BirthDate=employee.BirthDate,
                Salary=employee.Salary,
                SalaryType=employee.SalaryType,
                EmployeeId=Guid.NewGuid(),
                JobTitle=employee.JobTitle,
                Department=employee.Department,
                AvailableHours=employee.AvailableHours
            });

            ModelState.Clear();
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public async Task<JsonResult> UpdateEmployee(UpdateEmployeeModel employee)
        {
            if (employee.EmployeeId == Guid.Empty)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            var result = await _employeeOrchestrator.UpdateEmployee(new EmployeeViewModel
            {
                FirstName=employee.FirstName,
                MiddleInitial=employee.MiddleInitial,
                LastName=employee.LastName,
                HireDate=employee.HireDate,
                BirthDate=employee.BirthDate,
                Salary=employee.Salary,
                SalaryType=employee.SalaryType,
                EmployeeId=employee.EmployeeId,
                JobTitle=employee.JobTitle,
                Department=employee.Department,
                AvailableHours=employee.AvailableHours
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> Search(string searchString)
        {
            var viewModel = await _employeeOrchestrator.SearchEmployee(searchString);

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }


        public async Task<ActionResult> EmpAnniversary()
        {
            var employeeDisplayModel = new EmployeeDisplayModel
            {
                Employees = await _employeeOrchestrator.GetAllEmployees()
            };

            return View(employeeDisplayModel);
        }
    }
}