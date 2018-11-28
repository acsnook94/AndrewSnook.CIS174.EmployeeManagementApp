function searchEmployee() {
    var search = $("#searchString").val().trim();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function (data) {
        $("#employeeId").val(data.EmployeeId);
        $("#firstName").val(data.FirstName);
        $("#middleInitial").val(data.MiddleInitial);
        $("#lastName").val(data.LastName);
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
    var salaryType = {'Hourly' : 1, 'Annual' : 2};

    var employeeId = $("#employeeId").val();
    var firstName = $("#firstName").val();
    var middleInitial = $("#middleInitial").val();
    var lastName = $("#lastName").val();
    var hireDate = $("#hireDate").val();
    var birthDate = $("#birthDate").val();
    var salary = $("#salary").val();
    var salaryType;

    var salaryTypeOption = $("#salaryType").val();
    if (salaryTypeOption == salaryType.Hourly) {
        salaryType = 'Hourly';
    }
    else if (salaryTypeOption == salaryType.Annual) {
        salaryType = 'Annual';
    }
    else {
        salaryType = '';
    }
    
    var jobTitle = $("#jobTitle").val();
    var department = $("#department").val();
    var availableHours = $("#availableHours").val();

    $.ajax({
        url: "UpdateEmployee",
        dataType: "json",
        data: {
            EmployeeId: employeeId,
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
        if (data & (salaryType != '')) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        }
        else {
            $("#errorMessage").removeClass("hidden")
                .add("visible")
        }
    });
}

function BackToLogin() {
    location.href = "/Account/Login";
}

function ErrorGoToHome() {
    location.href = "/Home/Index";
}