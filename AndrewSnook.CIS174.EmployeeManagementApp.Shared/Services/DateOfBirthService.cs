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

        public bool IsTodayBirthDate(EmployeeViewModel employee)
        {
            return employee.BirthDate.Value.Date == _dateTimeService.Now().Date;
        }
    }
}
