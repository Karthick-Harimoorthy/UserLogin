<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiselect_sample.aspx.cs" Inherits="UserLogin.multiselect_sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery-1.4.2.min.js"></script>
       <link href="css/jquery.multiselect.css" rel="stylesheet" />
    <script src="js/jquery.multiselect.js"></script>
 
 <script type="text/javascript">
     $(function () {
         $("[id*=btnExport]").click(function () {
             $("[id*=hfGridHtml]").val($("#Grid").html());
         });
     });
</script>
</head>
<body>  
    <form runat="server">
      <div id="Grid">
    <table cellspacing="0" cellpadding="2" style="border-collapse: collapse;border: 1px solid #ccc;font-size: 9pt;">
        <tr>
            <th style="background-color: #B8DBFD;border: 1px solid #ccc">Customer Id</th>
            <th style="background-color: #B8DBFD;border: 1px solid #ccc">Name</th>
            <th style="background-color: #B8DBFD;border: 1px solid #ccc">Country</th>
        </tr>
        <tr>
            <td style="width:120px;border: 1px solid #ccc">1</td>
            <td style="width:150px;border: 1px solid #ccc">John Hammond</td>
            <td style="width:120px;border: 1px solid #ccc">United States</td>
        </tr>
        <tr>
            <td style="width:120px;border: 1px solid #ccc">2</td>
            <td style="width:150px;border: 1px solid #ccc">Mudassar Khan</td>
            <td style="width:120px;border: 1px solid #ccc">India</td>
        </tr>
        <tr>
            <td style="width:120px;border: 1px solid #ccc">3</td>
            <td style="width:150px;border: 1px solid #ccc">Suzanne Mathews</td>
            <td style="width:120px;border: 1px solid #ccc">France</td>
        </tr>
        <tr>
            <td style="width:120px;border: 1px solid #ccc">4</td>
            <td style="width:150px;border: 1px solid #ccc">Robert Schidner</td>
            <td style="width:120px;border: 1px solid #ccc">Russia</td>
        </tr>
    </table>
</div>
<br />
<asp:HiddenField ID="hfGridHtml" runat="server" />
<asp:Button ID="btnExport" runat="server" Text="Export To Excel" OnClick="ExportToExcel" />
    
 </form>

</body>
</html>
