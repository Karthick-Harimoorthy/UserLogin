using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Cookies_Helper
/// </summary>
public static class Cookies_Helper
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    //***********************************/
    //		LOGGED-IN USER
    //***********************************/
    public static void ClearCookies()
    {
        //Logged-In User
        HttpCookie emp_no = HttpContext.Current.Request.Cookies["EmployeeNo"];
        if (emp_no != null)
        {
            emp_no.Value = String.Empty;
            emp_no.Expires = DateTime.Now.AddYears(-30);
            HttpContext.Current.Response.SetCookie(emp_no);
        }

        HttpCookie emp_first_name = HttpContext.Current.Request.Cookies["EmployeeFirstName"];
        if (emp_first_name != null)
        {
            emp_first_name.Value = String.Empty;
            emp_first_name.Expires = DateTime.Now.AddYears(-30);
            HttpContext.Current.Response.SetCookie(emp_first_name);
        }

        HttpCookie emp_last_name = HttpContext.Current.Request.Cookies["EmployeeLastName"];
        if (emp_last_name != null)
        {
            emp_last_name.Value = String.Empty;
            emp_last_name.Expires = DateTime.Now.AddYears(-30);
            HttpContext.Current.Response.SetCookie(emp_last_name);
        }

        HttpCookie emp_is_supervisor = HttpContext.Current.Request.Cookies["EmployeeIsSupervisor"];
        if (emp_is_supervisor != null)
        {
            emp_is_supervisor.Value = String.Empty;
            emp_is_supervisor.Expires = DateTime.Now.AddYears(-30);
            HttpContext.Current.Response.SetCookie(emp_is_supervisor);
        }

        HttpCookie emp_role = HttpContext.Current.Request.Cookies["EmployeeRole"];
        if (emp_role != null)
        {
            emp_role.Value = String.Empty;
            emp_role.Expires = DateTime.Now.AddYears(-30);
            HttpContext.Current.Response.SetCookie(emp_role);
        }

        HttpCookie login_from = HttpContext.Current.Request.Cookies["From"];
        if (login_from != null)
        {
            login_from.Value = String.Empty;
            login_from.Expires = DateTime.Now.AddYears(-30);
            HttpContext.Current.Response.SetCookie(login_from);
        }
    }

    //Get Logged in Employee ID
    public static string GetEmployeeLoggedInNo()
    {
        HttpCookie emp_no = HttpContext.Current.Request.Cookies["EmployeeNo"];
        if (emp_no == null)
            return String.Empty;
        else
            return emp_no.Value;
    }
    //Set Logged in Employee ID
    public static void SetEmployeeLoggedInNo(string inEmployeeNo)
    {
        HttpCookie emp_no = HttpContext.Current.Request.Cookies["EmployeeNo"];
        if (emp_no == null)
        {
            emp_no = new HttpCookie("EmployeeNo");
            emp_no.Value = inEmployeeNo;
            emp_no.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.Cookies.Add(emp_no);
        }
        else
        {
            emp_no.Value = inEmployeeNo;
            emp_no.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.SetCookie(emp_no);
        }
    }

    //Get Logged in Employee First Name
    public static string GetEmployeeLoggedInFirstName()
    {
        HttpCookie emp_first_name = HttpContext.Current.Request.Cookies["EmployeeFirstName"];
        if (emp_first_name == null)
            return String.Empty;
        else
            return emp_first_name.Value;
    }
    //Set Logged in Employee First Name
    public static void SetEmployeeLoggedInFirstName(string inFirstName)
    {
        HttpCookie emp_first_name = HttpContext.Current.Request.Cookies["EmployeeFirstName"];
        if (emp_first_name == null)
        {
            emp_first_name = new HttpCookie("EmployeeFirstName");
            emp_first_name.Value = inFirstName;
            emp_first_name.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.Cookies.Add(emp_first_name);
        }
        else
        {
            emp_first_name.Value = inFirstName;
            emp_first_name.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.SetCookie(emp_first_name);
        }
    }

    //Get Logged in Employee Last Name
    public static string GetEmployeeLoggedInLastName()
    {
        HttpCookie emp_last_name = HttpContext.Current.Request.Cookies["EmployeeLastName"];
        if (emp_last_name == null)
            return String.Empty;
        else
            return emp_last_name.Value;
    }
    //Set Logged in Employee Last Name
    public static void SetEmployeeLoggedInLastName(string inLastName)
    {
        HttpCookie emp_last_name = HttpContext.Current.Request.Cookies["EmployeeLastName"];
        if (emp_last_name == null)
        {
            emp_last_name = new HttpCookie("EmployeeLastName");
            emp_last_name.Value = inLastName;
            emp_last_name.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.Cookies.Add(emp_last_name);
        }
        else
        {
            emp_last_name.Value = inLastName;
            emp_last_name.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.SetCookie(emp_last_name);
        }
    }

    //Get Logged in Employee Role
    public static string GetEmployeeLoggedInIsSupervisor()
    {
        string ret_value = String.Empty;
        HttpCookie emp_role = HttpContext.Current.Request.Cookies["EmployeeIsSupervisor"];
        if (emp_role == null)
            return String.Empty;
        else
            return emp_role.Value;
    }
    //Set Logged in Employee Role
    public static void SetEmployeeLoggedInIsSupervisor(string inIsSupervisor)
    {
        HttpCookie emp_is_supervisor = HttpContext.Current.Request.Cookies["EmployeeIsSupervisor"];
        if (emp_is_supervisor == null)
        {
            emp_is_supervisor = new HttpCookie("EmployeeIsSupervisor");
            emp_is_supervisor.Value = inIsSupervisor;
            emp_is_supervisor.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.Cookies.Add(emp_is_supervisor);
        }
        else
        {
            emp_is_supervisor.Value = inIsSupervisor;
            emp_is_supervisor.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.SetCookie(emp_is_supervisor);
        }
    }

    public static string GetEmployeeLogInFrom()
    {
        string ret_value = String.Empty;
        HttpCookie emp_from = HttpContext.Current.Request.Cookies["From"];
        if (emp_from == null)
            return String.Empty;
        else
            return emp_from.Value;
    }

    public static void SetEmployeeLogInFrom(string from)
    {
        HttpCookie emp_from = HttpContext.Current.Request.Cookies["From"];
        if (emp_from == null)
        {
            emp_from = new HttpCookie("From");
            emp_from.Value = from;
            emp_from.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.Cookies.Add(emp_from);
        }
        else
        {
            emp_from.Value = from;
            emp_from.Expires = DateTime.Now.AddYears(30);
            HttpContext.Current.Response.SetCookie(emp_from);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
