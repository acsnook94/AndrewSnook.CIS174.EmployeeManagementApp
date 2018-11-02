using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services
{
    public class DateOfHireService : IDateOfHireService
    {
        private readonly IDateTimeService _dateTimeService;

        public DateOfHireService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public int FullYearsSinceHireDate(EmployeeViewModel employee)
        {
           if(_dateTimeService.Now().Value.DayOfYear >= employee.HireDate.Value.DayOfYear){
                return (_dateTimeService.Now().Value.Year - employee.HireDate.Value.Year);
            }
            else
            {
                return ((_dateTimeService.Now().Value.Year - employee.HireDate.Value.Year) - 1);
            }
        }

        public bool IsTodayHireDate(EmployeeViewModel employee)
        {
            return (employee.HireDate.Value.DayOfYear == _dateTimeService.Now().Value.DayOfYear);
        }
    }
}
