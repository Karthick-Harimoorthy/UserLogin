<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqgridView.aspx.cs" Inherits="UserLogin.JqgridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>jqgrid data table</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js" type="text/javascript"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.20/js/dataTables.jqueryui.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/scroller/2.0.1/js/dataTables.scroller.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.20/css/dataTables.jqueryui.min.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/scroller/2.0.1/css/scroller.jqueryui.min.css" />
    <script type="text/javascript">  


        $(document).ready(function () {
          
            $.ajax({
                type: 'GET',
                url: "UserDetails.asmx/DisplayDataTables",
                dataType: 'json',
                success: function (data) {
                    $.each(data, function (i,data) {
                        var body = "<tr>";
                        body += "<td><input type='checkbox' name='select_all' value='1' id='datatable - select - all'/></td>";
                        body += "<td>" + data.FirstName + "</td>";
                        body += "<td>" + data.LastName + "</td>";
                        body += "<td>" + data.Emailid + "</td>";
                        body += "<td>" + data.Qualification + "</td>";
                        body += "</tr>";
                        $("#dataGrid tbody").append(body);
                    });

                    var table = $('#dataGrid').DataTable({
                        'columnDefs': [{
                            'targets': 0,
                            'searchable': false,
                            'orderable': false,
                            'className': 'dt-body-center',
                            'render': function (data, type, full, meta) {
                                return '<input type="checkbox" name="id[]" value="'
                                    + $('<div/>').text(data).html() + '">';
                            }
                        }],
                        'order': [1, 'asc']
                    });


                    $('#datatable-select-all').on('click', function () {
                        var rows = table.rows({ 'search': 'applied' }).nodes();
                        $('input[type="checkbox"]', rows).prop('checked', this.checked);
                    });


                    $('#dataGrid tbody').on('change', 'input[type="checkbox"]', function () {
                        if (!this.checked) {
                            var el = $('#datatable-select-all').get(0);
                            if (el && el.checked && ('indeterminate' in el)) {
                                el.indeterminate = true;
                            }
                        }
                    });
                    
                },


            });
        });
    </script>
</head>
<body style="font-family: Arial; font-size: 15pt">
    <table id="dataGrid" class="display nowrap" style="width: 100%">
        <thead>
            <tr>
                <th><input type="checkbox" name="select_all" value="1" id="datatable-select-all" /></th>
                <th>First name</th>
                <th>Last name</th>
                <th>Email ID</th>
                <th>Qualfication</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</body>
</html>
