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
    public class HireDateServiceTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker.GetMock<IDateTimeService>()
                .Setup(x => x.Now())
                .Returns(new DateTime(2018, 10, 30));
        }

        [TestMethod]
        public void HireDateToday_ReturnsTrue_When_HireDateMatchesToday()
        {
            var employee = CreateEmployee(new DateTime(2018,10,30));

            var dateOfHireService = _mocker.Create<DateOfHireService>();

            var IsHireDate = dateOfHireService.IsTodayHireDate(employee);

            Assert.IsTrue(IsHireDate);

        }

        [TestMethod]
        public void HireDateToday_ReturnsFalse_When_HireDateIsNotToday()
        {
            var employee = CreateEmployee(new DateTime(2018,10,31));

            var dateOfHireService = _mocker.Create<DateOfHireService>();

            var IsHireDate = dateOfHireService.IsTodayHireDate(employee);

            Assert.IsFalse(IsHireDate);

        }

        [TestMethod]
        public void SinceHireAndExpectedFullYears_AreEqual_When_DayOfYearBeforeNow()
        {
            var employee = CreateEmployee(new DateTime(2001,10,29));

            var dateOfHireService = _mocker.Create<DateOfHireService>();

            var actualYearsSince = dateOfHireService.FullYearsSinceHireDate(employee);

            var expectedYearsSince = 17;

            Assert.AreEqual(expectedYearsSince, actualYearsSince);
        }

        [TestMethod]
        public void SinceHireAndExpectedFullYears_AreEqual_When_DayOfYearEqualToNow()
        {
            var employee = CreateEmployee(new DateTime(2001,10,30));

            var dateOfHireService = _mocker.Create<DateOfHireService>();

            var actualYearsSince = dateOfHireService.FullYearsSinceHireDate(employee);

            var expectedYearsSince = 17;

            Assert.AreEqual(expectedYearsSince, actualYearsSince);
        }

        [TestMethod]
        public void SinceHireAndExpectedFullYears_AreEqual_When_DayOfYearAfterNow()
        {
            var employee = CreateEmployee(new DateTime(2001,10,31));

            var dateOfHireService = _mocker.Create<DateOfHireService>();

            var actualYearsSince = dateOfHireService.FullYearsSinceHireDate(employee);

            var expectedYearsSince = 16;

            Assert.AreEqual(expectedYearsSince, actualYearsSince);
        }

        private EmployeeViewModel CreateEmployee(DateTime hireDate)
        {
            return new EmployeeViewModel
            {
                FirstName = "Andy",
                MiddleInitial = "C",
                LastName = "Snook",
                HireDate = hireDate,
                BirthDate = new DateTime(2001,01,01),
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
