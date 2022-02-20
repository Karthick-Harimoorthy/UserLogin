<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="popup.aspx.cs" Inherits="UserLogin.popup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <link href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>   
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <div id="confirmBox">
    <div class="message"></div>
    <span class="yes">Yes</span>
    <span class="no">No</span>
             <button type="button" onclick="myFunction()">Delete</button>
</div>

        </div>
    </form>
</body>
</html>
