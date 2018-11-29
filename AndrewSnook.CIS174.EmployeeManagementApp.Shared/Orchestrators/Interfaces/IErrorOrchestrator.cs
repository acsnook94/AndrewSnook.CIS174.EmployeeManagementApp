using System;
using System.Threading.Tasks;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators.Interfaces
{
    public interface IErrorOrchestrator
    {
        Task<int> CreateErrorRecord(Exception ex);
    }
}
