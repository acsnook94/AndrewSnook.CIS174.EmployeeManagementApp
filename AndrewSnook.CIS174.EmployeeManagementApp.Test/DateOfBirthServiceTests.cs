using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Test
{
    [TestClass]
    public class DateOfBirthServiceTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestMethod]
        public void BirthDateToday_ReturnsTrue_When_BirthDateMatchesToday()
        {
            _mocker.GetMock<IDateTimeService>()
                .Setup(x => x.Now())
                .Returns(new DateTime(2018, 10, 31));

            var employee = new EmployeeViewModel
            {
                EmployeeId = Guid.NewGuid();
            }
        }
    }
}
