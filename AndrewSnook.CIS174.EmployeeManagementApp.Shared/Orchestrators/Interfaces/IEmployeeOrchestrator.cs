using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators.Interfaces
{
    interface IEmployeeOrchestrator
    {
        Task<List<EmployeeViewModel>> GetAllEmployees();
    }
}
