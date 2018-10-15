using AndrewSnook.CIS174.EmployeeManagementApp.Domain;
using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators
{
    public class EmployeeOrchestrator : IEmployeeOrchestrator
    {
        private EmployeeContext _employeeContext;

        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
            {
                EmployeeID = employee.EmployeeID,
                FirstName = employee.FirstName,
                MiddleInitial = employee.MiddleInitial,
                LastName = employee.LastName,
                HireDate = employee.HireDate,
                BirthDate = employee.BirthDate,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                JobTitle = employee.JobTitle,
                Department = employee.Department,
                AvailableHours = employee.AvailableHours

            });

            return await _employeeContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                MiddleInitial = x.MiddleInitial,
                LastName = x.LastName,
                HireDate = x.HireDate,
                BirthDate = x.BirthDate,
                Salary = x.Salary,
                SalaryType = x.SalaryType,
                JobTitle = x.JobTitle,
                Department = x.Department,
                AvailableHours = x.AvailableHours
            }).ToListAsync();

            return employees;
        }
    }
}
