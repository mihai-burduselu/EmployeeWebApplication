
var hub = $.connection.employeesHub;

hub.client.employeeAdded = function (employee) {
    $("#employeeList").append('<li id=employee' + employee.FirstName + '>' + employee.FirstName + ' ' + employee.LastName + '</li>');
};

$.ajax({

    url: '/api/Employee/Get',

    method: 'GET',

    dataType: 'json',

    success: populateEmployeeList

});

//call to get the list of products

function populateEmployeeList(employees) {

    $.each(employees, function (index) {

        var employee = employees[index];

        $("#employeeList").append('<li id=employee' + employee.FirstName + '>' + employee.FirstName + ' ' + employee.LastName + '</li>');

    });

}

//method to be called on success


//when we click the button "#createButton", we:
$("#createButton").click(function () {//

    //Create the variable employee
    var employee = {//

        FirstName: $("#firstNameInput").val(),

        LastName: $("#lastNameInput").val(),

        Address: $("#addressInput").val(),

        Age: $("#ageInput").val(),

        Salary: $("#salaryInput").val()

    };//
    //send a request with this new variable to controller
    $.ajax({//

        url: '/api/Employee/CreateEmployee',//to the CreateEmployee method

        type: 'POST',

        data: employee

    });//

});//

$("#updateButton").click(function () {
    var employee = {
        FirstName: $("#firstNameInput").val(),
        LastName: $("#lastNameInput").val(),
        Address: $("#addressInput").val(),
        Age: $("#ageInput").val(),
        Salary: $("#salaryInput").val()
    };

    $.ajax({
        url: 'api/Employee/Update',
        type: 'POST',
        data: employee
    });

});

$("#deleteButton").click(function () {
    var employee = {
        FirstName: $("#firstNameInput").val(),
        LastName: $("#lastNameInput").val(),
        Address: null,
        Age: null,
        Salary: null
    };

    $.ajax({
        url: 'api/Employee/Delete',
        type: 'DELETE',
        data: employee
    });

});

// this is called when the button is clicked


$.connection.hub.logging = true;
$.connection.hub.start();