using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController()
        {
            _employeeOrchestrator = new EmployeeOrchestrator();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeOrchestrator.GetAllEmployees();

            return employees;
        }
    }
}
