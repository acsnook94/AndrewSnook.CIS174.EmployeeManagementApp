using AndrewSnook.CIS174.EmployeeManagementApp.Domain.Entities;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.Services.Interfaces;
using AndrewSnook.CIS174.EmployeeManagementApp.Shared.ViewModels;
using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AndrewSnook.CIS174.EmployeeManagementApp.Test
{
    [TestClass]
    public class BirthDateServiceTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker.GetMock<IDateTimeService>()
                .Setup(x => x.Now())
                .Returns(new DateTime(2018, 10, 29));
        }

        [TestMethod]
        public void BirthDateToday_ReturnsTrue_When_BirthDateMatchesToday()
        {
            var employee = CreateEmployee(new DateTime(2018,10,29));

            var dateOfBirthService = _mocker.Create<DateOfBirthService>();

            var IsBirthDate = dateOfBirthService.IsTodayBirthDate(employee);

            Assert.IsTrue(IsBirthDate);

        }

        [TestMethod]
        public void BirthDateToday_ReturnsFalse_When_BirthDateIsNotToday()
        {
            var employee = CreateEmployee(new DateTime(2018,10,30));

            var dateOfBirthService = _mocker.Create<DateOfBirthService>();

            var IsBirthDate = dateOfBirthService.IsTodayBirthDate(employee);

            Assert.IsFalse(IsBirthDate);

        }

        [TestMethod]
        public void SinceBirthAndExpectedFullYears_AreEqual_When_DayOfYearBeforeNow()
        {
            var employee = CreateEmployee(new DateTime(2001,10,28));

            var dateOfBirthService = _mocker.Create<DateOfBirthService>();

            var actualYearsSince = dateOfBirthService.FullYearsSinceBirthDate(employee);

            var expectedYearsSince = 17;

            Assert.AreEqual(expectedYearsSince, actualYearsSince);
        }

        [TestMethod]
        public void SinceBirthAndExpectedFullYears_AreEqual_When_DayOfYearEqualToNow()
        {
            var employee = CreateEmployee(new DateTime(2001,10,29));

            var dateOfBirthService = _mocker.Create<DateOfBirthService>();

            var actualYearsSince = dateOfBirthService.FullYearsSinceBirthDate(employee);

            var expectedYearsSince = 17;

            Assert.AreEqual(expectedYearsSince, actualYearsSince);
        }

        [TestMethod]
        public void SinceBirthAndExpectedFullYears_AreEqual_When_DayOfYearAfterNow()
        {
            var employee = CreateEmployee(new DateTime(2001,10,30));

            var dateOfBirthService = _mocker.Create<DateOfBirthService>();

            var actualYearsSince = dateOfBirthService.FullYearsSinceBirthDate(employee);

            var expectedYearsSince = 16;

            Assert.AreEqual(expectedYearsSince, actualYearsSince);
        }

        private EmployeeViewModel CreateEmployee(DateTime birthDate)
        {
            return new EmployeeViewModel
            {
                FirstName = "Andy",
                MiddleInitial = "C",
                LastName = "Snook",
                HireDate = new DateTime(2001,01,01),
                BirthDate = birthDate,
                Salary=2,
                SalaryType=SalaryType.Hourly,
                EmployeeId=Guid.NewGuid(),
                JobTitle="Peasant",
                Department="Housekeeping",
                AvailableHours="Never"
            };
        }
    }
}
