using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using AndrewSnook.CIS174.EmployeeManagementApp.Web.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();

        // GET: Employee
        public async Task<ActionResult> Index()
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
                EmployeeID = Guid.NewGuid(),
                FirstName=employee.FirstName,
                MiddleInitial=employee.MiddleInitial,
                LastName=employee.LastName,
                HireDate=employee.HireDate,
                BirthDate=employee.BirthDate,
                Salary=employee.Salary,
                SalaryType=employee.SalaryType,
                JobTitle=employee.JobTitle,
                Department=employee.Department,
                AvailableHours=employee.AvailableHours
            });

            return View();
        }
    }
}