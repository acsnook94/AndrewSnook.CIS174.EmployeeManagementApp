using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using AndrewSnook.CIS174.EmployeeManagementApp.Domain;
using System.Web.Http;
using AndrewSnook.CIS174.EmployeeManagementApp.Api.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeContext _employeeContext;

        public EmployeeController()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<ICollection<EmployeeModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeModel
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                MiddleInitial = x.MiddleInitial,
                LastName = x.LastName,
                HireDate = x.HireDate,
                BirthDate = x.BirthDate,
                Salary = x.Salary,
                SalaryType = (SalaryType) x.SalaryType,
                JobTitle = x.JobTitle,
                Department = x.Department,
                AvailableHours = x.AvailableHours
            }).ToListAsync();

            return employees;
        }
    }
}
