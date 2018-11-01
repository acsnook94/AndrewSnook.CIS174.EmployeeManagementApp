using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces
{
    public interface IDateOfHireService
    {
        bool IsTodayHireDate(EmployeeViewModel employee);
        int FullYearsSinceHireDate(EmployeeViewModel employee);
    }
}
