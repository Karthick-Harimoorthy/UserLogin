<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_productivity_data.aspx.cs" Inherits="UserLogin.admin_productivity_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>S&C Digital Dashboard - Productivity Data</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js"></script>
       <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js"></script>
    <script src="js/jquery.multiselect.js"></script>
   <%-- <link href="css/main.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="js/main.js"></script>--%>

    <!-- DateTimePicker -->
  <%--  <link href="css/ui-lightness/jquery-ui-1.10.3.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="js/jquery-ui-1.10.3.custom.js"></script>
    <script type="text/javascript" src="js/jquery.datetimepicker.js"></script>
    <link href="css/jquery.datetimepicker.css" rel="stylesheet" type="text/css" />--%>

    <!-- DateTimePicker -->

    <script type="text/javascript">
        $(document).ready(function () {
            InitializeDates();
        });
    </script>

    <!-- Multi Select -->
    <%--<script src="js/jquery.multiselect.productivity.js" type="text/javascript"></script>
    <link href="css/jquery.multiselect.productivity.css" rel="stylesheet" />--%>
    <!-- Multi Select -->

    <script type="text/javascript">  
        $(document).ready(function () {

            InitializeDropDown();
        });

        function InitializeDates() {

            $("#StartDate").datepicker();
            $("#EndDate").datepicker();
        }

        function InitializeDropDown() {
          
                $('#DepartmentLB').multiselect({
                    columns: 1,
                    placeholder:'select any',
                    selectAll:true
                 
                });

                $('[id*=LaborTypeLB]').multiselect({
                    includeSelectAllOption: true
                });

                $('[id*=StandardLaborLB]').multiselect({
                    includeSelectAllOption: true
                });

                $('[id*=IndirectAccountLB]').multiselect({
                    includeSelectAllOption: true
                });

        }

       
    </script>
</head>
<body style="background-color: #30744C;">
    <form id="form1" runat="server">
        <div class="center">
            <!-- Header -->
            <table border="0" cellpadding="0" cellspacing="0">
                <%--<tr>
            <td align="center" valign="middle" style="width:100%; height:85px;">
               <Header:PgHeader ID="PgHeader" runat="server" />
            </td>
        </tr> --%>
                <tr>
                    <td>
                        <img src="images/white.jpg" width="100%;" height="4px" alt="" /></td>
                </tr>
                <tr>
                    <td>
                        <img src="images/x.gif" width="1px" height="20px" alt="" />
                    </td>
                </tr>
                <!-- Header -->
                <!-- contents -->
                <tr>
                    <td class="contents" align="center" valign="middle" style="height: 352px; background-color: #30744C;">
                        <%--<asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="AjaxPanel" runat="server">
                    <ProgressTemplate>
                        <div style="background-color:Gray; filter:alpha(opacity=80); opacity:0.80; width: 100%; top: 0px; left: 0px; position: fixed; height: 800px;">
                        </div>
                        <div style="width:100%; height:100%; margin:auto; filter:alpha(opacity=100); opacity:1; font-size:small; vertical-align: middle; top: auto; position: absolute; right: auto; color: #FFFFFF;">
                            <table border="0" cellpadding="0" cellspacing="0" align="center" style="width:100%; height:100%;">
                            <tr>
                                <td align="center" valign="middle">
                                    <table border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td align="left" valign="middle"><img src="images/loading.gif" alt="Loading" /></td>
                                        <td align="left" valign="top"><img src="images/x.gif" width="8px" height="1px" alt="" /></td>
                                        <td align="left" valign="middle" style="color: #FFFFFF; font-size: 14px; font-weight: bold;">please wait...</td>
                                    </tr>
                                    </table>
                                </td>
                            </tr>
                            </table>
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>--%>
                        <%--<asp:UpdatePanel ID="AjaxPanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>    
                </ContentTemplate>
                </asp:UpdatePanel>--%>
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td align="center" valign="middle">
                                    <table border="0" cellpadding="0" cellspacing="0" class="c_wrapper_inset" style="width: 500px; background-color: #30744C; color: #ffffff;">
                                        <tr>
                                            <td align="left" valign="top">
                                                <table border="0" cellpadding="8" cellspacing="0">
                                                    <tr>
                                                        <td align="center" valign="middle">
                                                            <table border="0" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td align="center" valign="middle">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="1px" height="10px" alt="" /></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="right" valign="middle" class="header2" style="white-space: nowrap">Department:&nbsp;&nbsp;</td>
                                                                                <td align="left" valign="middle" style="color: black; width: 100px;">
                                                                                    <asp:ListBox ID="DepartmentLB" runat="server" multiple="multiple" Width="100px" AutoPostBack="true">
                                                                                        <Items>
                                                                                            <asp:ListItem text="Item1" value="10" />
                                                                                            <asp:ListItem text="Item2" value="20" />
                                                                                            <asp:ListItem text="Item3" value="30" />
                                                                                               <asp:ListItem text="Item4" value="40" />
                                                                                            <asp:ListItem text="Item5" value="50" />
                                                                                            <asp:ListItem text="Item6" value="60" />
                                                                                        </Items>
                                                                                    </asp:ListBox>
                                                                                </td>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="10px" height="1px" alt="" /></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                    <td align="center" valign="middle">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="1px" height="10px" alt="" /></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="right" valign="middle" class="header2" style="white-space: nowrap">Labor Type:&nbsp;&nbsp;</td>
                                                                                <td align="left" valign="middle" style="color: black; width: 100px;">
                                                                                    <asp:ListBox ID="LaborTypeLB" runat="server" SelectionMode="Multiple" Width="100px"></asp:ListBox>
                                                                                </td>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="10px" height="1px" alt="" /></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                    <td align="center" valign="middle">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="1px" height="10px" alt="" /></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="right" valign="middle" class="header2" style="white-space: nowrap">Standard Labor Account:&nbsp;&nbsp;</td>
                                                                                <td align="left" valign="middle" style="color: black; width: 100px;">
                                                                                    <asp:ListBox ID="StandardLaborLB" runat="server" SelectionMode="Multiple" Width="100px"></asp:ListBox>
                                                                                </td>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="10px" height="1px" alt="" /></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                    <td align="center" valign="middle">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="1px" height="10px" alt="" /></td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="right" valign="middle" class="header2" style="white-space: nowrap">Indirect Account:&nbsp;&nbsp;</td>
                                                                                <td align="left" valign="middle" style="color: black; width: 100px;">
                                                                                    <asp:ListBox ID="IndirectAccountLB" runat="server" SelectionMode="Multiple" Width="100px"></asp:ListBox>
                                                                                </td>
                                                                                <td>
                                                                                    <img src="images/x.gif" width="10px" height="1px" alt="" /></td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <img src="images/x.gif" width="1px" height="30px" alt="" /></td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <img src="images/x.gif" width="1px" height="10px" alt="" />
                                                                        <td align="center" valign="middle">
                                                                            <table border="0" cellpadding="0" cellspacing="0">
                                                                                <tr>
                                                                                    <td>
                                                                                        <img src="images/x.gif" width="1px" height="10px" alt="" /></td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td align="right" valign="middle" class="header2" style="white-space: nowrap">Start Date:&nbsp;&nbsp;</td>
                                                                                    <td align="left" valign="middle">
                                                                                        <asp:TextBox ID="StartDate" Width="150px" Height="21px" AutoComplete="off" runat="server"></asp:TextBox>
                                                                                    </td>
                                                                                    <td>
                                                                                        <img src="images/x.gif" width="3px" height="1px" alt="" /></td>
                                                                                    <td align="left" valign="middle" class="msg" style="height: 20px;">*</td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                        <td align="center" valign="middle">
                                                                            <table border="0" cellpadding="0" cellspacing="0">
                                                                                <tr>
                                                                                    <td>
                                                                                        <img src="images/x.gif" width="1px" height="10px" alt="" /></td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td align="right" valign="middle" class="header2">End Date:&nbsp;&nbsp;</td>
                                                                                    <td align="left" valign="middle">
                                                                                        <asp:TextBox ID="EndDate" Width="150px" Height="21px" AutoComplete="off" runat="server"></asp:TextBox>
                                                                                    </td>
                                                                                    <td>
                                                                                        <img src="images/x.gif" width="3px" height="1px" alt="" /></td>
                                                                                    <td align="left" valign="middle" class="msg">*</td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <img src="images/x.gif" width="1px" height="30px" alt="" /></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <img src="images/x.gif" width="1px" height="5px" alt="" /></td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" valign="middle">
                                                            <asp:ImageButton ID="SubmitImageBtn" ImageUrl="~/images/submit.png" Width="100px" Height="40px" runat="server" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <img src="images/x.gif" width="1px" height="5px" alt="" /></td>
                                                    </tr>
                                                    <tr>
                                                        <td id="MsgLbl" class="msg" align="center" valign="middle" style="width: 500px;" runat="server">&nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <!-- contents -->
                <!-- Footer -->
                <tr>
                    <td>
                        <img src="images/x.gif" width="1px" height="20px" alt="" /></td>
                </tr>
                <tr>
                    <td>
                        <img src="images/white.jpg" width="100%;" height="4px" alt="" /></td>
                </tr>
                <%--<tr>          
            <td align="left" valign="middle" style="width:100%; height: 35px;">
                <Footer:PgFooter ID="PgFooter" runat="server" />
            </td>           
        </tr>--%>
                <!-- Footer -->
            </table>
        </div>
        <!-- initialize -->
        <script language="javascript" type="text/javascript">
            function pageLoad(sender, args) {
                if (args.get_isPartialLoad()) {
                    InitializeDates();
                }
            }
        </script>
        <!-- initialize -->
    </form>
</body>
</html>

</html>
