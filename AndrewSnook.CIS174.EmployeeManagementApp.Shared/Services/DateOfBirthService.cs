using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services
{
    public class DateOfBirthService : IDateOfBirthService
    {
        private readonly IDateTimeService _dateTimeService;

        public DateOfBirthService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public int FullYearsSinceBirthDate(EmployeeViewModel employee)
        {
            if(employee.BirthDate.DayOfYear <= _dateTimeService.Now().Value.DayOfYear){
                return _dateTimeService.Now().Value.Year - employee.BirthDate.Year;
            }
            else
            {
                return _dateTimeService.Now().Value.Year - employee.BirthDate.Year - 1;
            }
        }

        public bool IsTodayBirthDate(EmployeeViewModel employee)
        {
            return (employee.BirthDate.Date == _dateTimeService.Now().Value.Date);
        }
    }
}
