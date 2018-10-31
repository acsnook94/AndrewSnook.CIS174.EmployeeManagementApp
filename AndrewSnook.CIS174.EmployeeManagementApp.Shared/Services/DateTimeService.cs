using System;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
