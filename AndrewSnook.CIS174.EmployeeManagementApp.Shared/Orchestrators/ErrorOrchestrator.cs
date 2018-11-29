using AndrewSnook.CIS174.EmployeeManagementApp.Domain;
using AndrewSnook.CIS174.EmployeeManagementApp.Entities;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators.Interfaces;
using System;
using System.Threading.Tasks;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Orchestrators
{
    public class ErrorOrchestrator : IErrorOrchestrator
    {
        private readonly EmployeeContext _employeeContext;

        public ErrorOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

        public Task CreateErrorRecord(Exception ex)
        {
            _employeeContext.Errors.Add(new Error
            {
                ID = Guid.NewGuid(),
                ErrorDateTime = DateTime.Now,
                ErrorMessage = ex.Message + Environment.NewLine + ex.InnerException.Message,
                StackTrace = ex.StackTrace
            });

            return _employeeContext.SaveChangesAsync();
        }
    }
}
