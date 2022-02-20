<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tablecell.aspx.cs" Inherits="UserLogin.Tablecell" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Table Cell</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js" type="text/javascript"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.20/js/dataTables.jqueryui.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/scroller/2.0.1/js/dataTables.scroller.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.20/css/dataTables.jqueryui.min.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/scroller/2.0.1/css/scroller.jqueryui.min.css" />
    <%--<script type="text/javascript">  


        $(document).ready(function () {
          
            $.ajax({
                type: 'GET',
                url: "UserDetails.asmx/Tablecell",
                dataType: 'json',
                success: function (data) {
                    $.each(data, function (i,data) {
                        var body = "<tr>";
                        body += "<td>" + data.FirstName + "</td>";
                        body += "<td>" + data.LastName + "</td>";
                        body += "<td>" + data.Emailid + "</td>";
                        body += "<td>" + data.Qualification + "</td>";
                        body += "<td>" + data.PhNo + "</td>";
                        body += "<td>" + data.Country + "</td>";
                        body += "<td>" + data.State + "</td>";
                        body += "<td>" + data.City + "</td>";
                        body += "</tr>";
                        $("#Tablecell tbody").append(body);
                    });

                  
                    
                },


            });
        });
    </script>--%>
</head>
<body style="font-family: Arial; font-size: 10pt">
 <%--   <table id="Tablecell" class="display nowrap" style="width: 100%">
        <thead>
            <tr>
                <th>First name</th>
                <th>Last name</th>
                <th>Email ID</th>
                <th>Qualfication</th>
                <th>Ph No</th>
                <th>Country</th>
                <th>State</th>
                <th>City</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>--%>
    <asp:Panel ID="pnl" runat="server"></asp:Panel>
     
</body>
</html>
