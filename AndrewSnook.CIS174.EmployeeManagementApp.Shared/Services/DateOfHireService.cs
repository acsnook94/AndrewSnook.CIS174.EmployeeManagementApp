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
           if(_dateTimeService.Now().Value.DayOfYear >= employee.HireDate.DayOfYear){
                return (_dateTimeService.Now().Value.Year - employee.HireDate.Year);
            }
            else
            {
                return ((_dateTimeService.Now().Value.Year - employee.HireDate.Year) - 1);
            }
        }

        public bool IsTodayHireDate(EmployeeViewModel employee)
        {
            return (employee.HireDate.Date == _dateTimeService.Now().Value.Date);
        }
    }
}
