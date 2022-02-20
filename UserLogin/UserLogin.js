$(document).ready(function () {
    $("#Datatable").click(function () {

    });
    $("#Submit").click(function () {

        var FirstName = $("#Firstname").val();
        var LastName = $("#Lastname").val();
        var Emailid = $("#Email").val();
        var Qualification = $("#Qualification").val();
        var PhNo = $("#PhNo").val();
        var Country = $("#Country").val();
        var State = $("#State").val();
        var City = $("#City").val();

        if (FirstName == "" && LastName == "" && Emailid == "" && Qualification == "") {
            swal("Please Fill All Details")
        }
        else if (FirstName == "" || FirstName == null || FirstName === "undefined") {
            swal("Please Enter Your First Name")
        }
        else if (LastName == "" || LastName == null || LastName === "undefined") {
            swal("Please Enter Your Last Name")
        }
        else if (Qualification == "" || Qualification == null || Qualification === "undefined") {
            swal("Please Enter Your Qualification")
        }
        else if (Emailid == "" || Emailid == null || Emailid === "undefined") {
            swal("Please Enter Your Emailid")
        }
        else if (PhNo == "" || PhNo == null || PhNo === "undefined") {
            swal("Please Enter Your Phone Number")
        }
        else if (Country == "" || Country == null || Country === "undefined") {
            swal("Please Enter Your Country")
        }
        else if (State == "" || State == null || State === "undefined") {
            swal("Please Enter Your State")
        }
        else if (City == "" || City == null || City === "undefined") {
            swal("Please Enter Your City")
        }
        else if (Emailid != "" || Emailid != null || Emailid !== "undefined") {

            if (/(.+)@(.+){2,}\.(.+){2,}/.test(Emailid) == false) {

                swal("Invalid Email Address")
            }
            else {

                var userDetails = function () {
                    $.ajax({
                        url: "UserDetails.asmx/UserDetailsStores",
                        type: 'POST',
                        data: "{ 'FirstName':' " + FirstName + "', 'LastName': '" + LastName + "', 'Emailid': '" + Emailid + "', 'Qualification': '" + Qualification + "','PhNo': '" + PhNo + "','Country': '" + Country + "','State': '" + State + "','City': '" + City + "' }",
                        contentType: 'application/json; charset=utf-8',
                        dataType: 'json',
                        success: function () {
                            swal("User Details Has Been Submited");
                        }
                    });
                }
                userDetails();

            }

        }
    });
    $("#Login").click(function () {
        var emailid = $("#Emailid").val();
        if (emailid == "" || emailid == null || emailid === "undefined") {
            swal("Please Enter Your Emailid")
            $('#useredit').modal('hide');
        }

        else {
            var DispDetails = function (emailid) {
                $.ajax({
                    url: "UserDetails.asmx/DisplayUserDetails",
                    type: 'POST',
                    data: { emailid: emailid },
                    dataType: 'json',
                    success: function (data) {
                        if (data.FirstName == null) {
                            $('#useredit').modal('hide');
                            swal("This Emailid Doesn't Exists")

                        }
                        else {
                            $('#useredit').modal('show');
                            $("#Firstname1").val(data.FirstName);
                            $("#Lastname1").val(data.LastName);
                            $("#Email1").val(data.Emailid);
                            $("#Qualification1").val(data.Qualification);
                            $("#PhNoedit").val(data.PhNo);
                            $("#Countryedit").val(data.Country);
                            $("#Stateedit").val(data.State);
                            $("#Cityedit").val(data.City);
                         
                        }
                    }
                });
            }
            DispDetails(emailid);
        }


    });
    $("#Delete").click(function () {
        var emailid = $("#Emailid1").val();
        if (emailid == "" || emailid == null || emailid === "undefined") {
            swal("Please Enter Your Emailid")
        }

        else {
            $.ajax({
                url: "UserDetails.asmx/DisplayUserDetails",
                type: 'POST',
                data: { emailid: emailid },
                dataType: 'json',
                success: function (data) {
                    if (data.FirstName == null) {
                        swal("This Emailid Doesn't Exists")
                    }
                    else {
                        var Delete = confirm("Are You Sure You Want To Delete");
                        if (Delete == true) {
                            DeleteDetails(emailid);
                        }
                        else {
                            return;
                        }
                    }
                }
            });

            var DeleteDetails = function (emailid) {
                $.ajax({
                    url: "UserDetails.asmx/DeleteUserAccount",
                    type: 'POST',
                    data: "{'emailid':'" + emailid + "'}",
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (data) {
                        swal("Your Account Has Been Deleted");
                    }
                });
            }
        }
    });


    $("#Update").click(function () {

        var FirstName = $("#Firstname1").val();
        var LastName = $("#Lastname1").val();
        var Emailid = $("#Email1").val();
        var Qualification = $("#Qualification1").val();
        var PhNo = $("#PhNoedit").val();
        var Country = $("#Countryedit").val();
        var State = $("#Stateedit").val();
        var City = $("#Cityedit").val();
        if (FirstName == "" && LastName == "" && Emailid == "" && Qualification == "") {
            swal("Please Submit All Details")
        }
        else if (FirstName == "" || FirstName == null || FirstName === "undefined") {
            swal("Please Enter Your First Name")
        }
        else if (LastName == "" || LastName == null || LastName === "undefined") {
            swal("Please Enter Your Last Name")
        }
        else if (Emailid == "" || Emailid == null || Emailid === "undefined") {
            swal("Please Enter Your Emailid")
        }
        else if (Qualification == "" || Qualification == null || Qualification === "undefined") {
            swal("Please Enter Your Qualification")
        }
        else if (PhNo == "" || PhNo == null || PhNo === "undefined") {
            swal("Please Enter Your Phone Number")
        }
        else if (Country == "" || Country == null || Country === "undefined") {
            swal("Please Enter Your Country")
        }
        else if (State == "" || State == null || State === "undefined") {
            swal("Please Enter Your State")
        }
        else if (City == "" || City == null || City === "undefined") {
            swal("Please Enter Your City")
        }
        else {
            var UpdateDetails = function () {
                $.ajax({
                    url: "UserDetails.asmx/UpdateUserDetails",
                    type: 'POST',
                    data: "{ 'FirstName':' " + FirstName + "', 'LastName': '" + LastName + "', 'Emailid': '" + Emailid + "', 'Qualification': '" + Qualification + "','PhNo': '" + PhNo + "','Country': '" + Country + "','State': '" + State + "','City': '" + City + "' }",
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function () {
                        swal("Your Details updated");
                    }
                });
            }
            UpdateDetails();

        }
    });

});

