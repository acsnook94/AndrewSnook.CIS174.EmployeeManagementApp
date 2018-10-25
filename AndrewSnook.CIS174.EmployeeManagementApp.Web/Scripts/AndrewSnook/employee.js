function searchEmployee() {
    var search = $("#searchString").val().trim();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function (data) {
        //var id =  $("#employeeId").val().toString();
        //$("#employeeId").val(data.EmployeeId);
        //$("#employeeId").val(id);
        $("#firstName").val(data.FirstName);
        $("#middleInitial").val(data.MiddleInitial);
        $("#lastName").val(data.LastName);

        //var hireYear = data.HireDate.substr(0,4);
        //var hireDay = data.HireDate.substr(5,2);
        //var hireMonth = data.HireDate.substr(7,2);
 
        //var hireDate = mome
        //var hireYear = hireDate.getFullYear();
        //var hireDay = hireDate.getDate();
        //var hireMonth = hireDate.getMonth() + 1; 
        //var inputDateVal;

        //if (hireDay.length < 2) {hireDay = '0' + hireDate};
        //if (hireMonth.length < 2) {hireMonth = '0' + hireMonth};
        //inputDateVal = hireYear + "-" + hireDay + "-" + hireMonth;

        //$("#hireDate").val(inputDateVal);
        $("#hireDate").val(data.HireDate);
        $("#birthDate").val(data.BirthDate);

        $("#salary").val(data.Salary);
        $("#salaryType").val(data.SalaryType);
        $("#jobTitle").val(data.JobTitle);
        $("#department").val(data.Department);
        $("#availableHours").val(data.AvailableHours);
    });
}

function updateEmployee() {
    var firstName = $("#firstName").val();
    var middleInitial = $("#middleInitial").val();
    var lastName = $("#lastName").val();
    var hireDate = $("#hireDate").val();
    var birthDate = $("#birthDate").val();
    var salary = $("#salary").val();
    var salaryType = $("salaryType").val();
    var jobTitle = $("#jobTitle").val();
    var department = $("#department").val();
    var availableHours = $("#availableHours").val();

    $.ajax({
        url: "UpdateEmployee",
        dataType: "json",
        data: {
            FirstName: firstName,
            MiddleInitial: middleInitial,
            LastName: lastName,
            HireDate: hireDate,
            BirthDate: birthDate,
            Salary: salary,
            SalaryType: salaryType,
            JobTitle: jobTitle,
            Department: department,
            AvailableHours: availableHours
        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        }
        else {
            $("#errorMessage").removeClass("hidden")
                .add("visible")
        }
    });
}