using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces
{
    public interface IDateOfBirthService
    {
        bool IsTodayBirthDate(EmployeeViewModel employee);
    }
}
