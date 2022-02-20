using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.IO;

/// <summary>
/// Summary description for Farm_Helper
/// </summary>
public static class NJS_Helper
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    //***********************************/
    //		FUNCTIONS
    //***********************************/
    public static string Capitalize(string value)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
    }
    
    public static string To_Date(string value)
    {
        if (value.Trim().Length > 0)
        {
            return Convert.ToDateTime(value).ToString("MM/dd/yyyy");
        }
        else
        {
            return "";
        } 
    }
    public static string To_DB_Date(string value)
    {
        if (value.Trim().Length > 0)
        {
            return Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
        else
        {
            return "";
        }
    }
    public static string To_Time(string value)
    {
        if (value.Trim().Length > 0)
        {
            return String.Format("{0:T}", Convert.ToDateTime(value));  
        }
        else
        {
            return "";
        }
    }

    public static string SubWords(string input, int numberWords)
    {
        try
        {
            // Number of words we still want to display.
            int words = numberWords;
            // Loop through entire summary.
            if (!input.Contains(" "))
                return input;
            for (int i = 0; i < input.Length; i++)
            {
                // Increment words on a space.
                if (input[i].ToString() == " ")
                {
                    words--;
                }
                // If we have no more words to display, return the substring.
                if (words == 0)
                {
                    return input.Substring(0, i) + " ... ";
                }
            }
        }
        catch (Exception)
        {
            // Log the error.
        }
        return "";
    }

    static public string GetFileSize(string filePath)
    {
        if (File.Exists(filePath))
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(filePath);

            int kb = Convert.ToInt32(fi.Length / 1024);
            return kb.ToString() + " kb";
        }
        else
            return "0 kb";
    }

    static public string HTMLToText(string str)
    {
        string newStr = "";
        if (str != null)
        {
            if (str != "")
            {
                newStr = str.Replace("<br/>", Environment.NewLine);
                newStr = newStr.Replace(" &nbsp;", "  ");
            }
        }
        return newStr;
    }

    static public string TextToHTML(string str)
    {
        string newStr = "";
        if (str != null)
        {
            if (str != "")
            {
                newStr = str.Replace("\r\n", "<br/>");
                newStr = newStr.Replace("\r", "<br/>");
                newStr = newStr.Replace("\n", "<br/>");
                newStr = newStr.Replace("  ", " &nbsp;");
            }
        }
        return newStr;
    }

    static public bool isOnlyNumbers(string inputStr)
    {
        string str = inputStr.Trim();

        double Num;
        bool isNum = double.TryParse(str, out Num);

        if (!isNum)
            return false;
        else
            return true;
    }

    static public string FormatStringforDB(string str)
    {
        string newStr = "";
        if (str != null)
        {
            if (str != "")
                newStr = str.Replace("'", @"\'");
        }
        return newStr;
    }

    static public void Download_File(string filePath)
    {
        try
        {
            // Identify the file name.
            string fileName = System.IO.Path.GetFileName(filePath);
            fileName = fileName.Replace(' ', '_'); //Browser compatibility

            //Clear Response
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ClearHeaders();
            HttpContext.Current.Response.ClearContent();

            //Transmit file to client
            if (fileName.Contains(".xls") || fileName.Contains(".xlsx"))
                HttpContext.Current.Response.ContentType = "application/ms-excel";
            else if (fileName.Contains(".zip"))
                HttpContext.Current.Response.ContentType = "application/x-zip-compressed";
            else if(fileName.Contains(".jpg") || fileName.Contains(".jpeg"))
                HttpContext.Current.Response.ContentType = "image/jpeg";
            else if (fileName.Contains(".gif"))
                HttpContext.Current.Response.ContentType = "image/gif";
            else if (fileName.Contains(".pdf"))
                HttpContext.Current.Response.ContentType = "application/pdf";
            
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            HttpContext.Current.Response.TransmitFile(filePath);

        }
        catch (Exception ex)
        {
            // Trap the error, if any.
            HttpContext.Current.Response.Write("Error : " + ex.Message);
        }
        finally
        {
            //End Response
            HttpContext.Current.Response.End();
        }
    }

    static public void Download_Response_Stream(Stream outputStream, string fileName)
    {
        try
        {
            //Transmit file to client
            if (fileName.Contains(".zip"))
                HttpContext.Current.Response.ContentType = "application/x-zip-compressed";
            else if (fileName.Contains(".jpg") || fileName.Contains(".jpeg"))
                HttpContext.Current.Response.ContentType = "image/jpeg";
            else if (fileName.Contains(".gif"))
                HttpContext.Current.Response.ContentType = "image/gif";
            else if (fileName.Contains(".pdf"))
                HttpContext.Current.Response.ContentType = "application/pdf";
            
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            HttpContext.Current.Response.Write(HttpContext.Current.Response.OutputStream);

        }
        catch (Exception ex)
        {
            // Trap the error, if any.
            HttpContext.Current.Response.Write("Error : " + ex.Message);
        }
        finally
        {
            //End Response
            HttpContext.Current.Response.End();
        }
    }

    public static string ReplaceNumWithNullifEmpty(string inValue)
    {
        if (inValue.Trim().Length == 0)
            return "null";
        else
            return inValue;
    }

    public static void Show(string message, Control owner)
    {
        Page page = (owner as Page) ?? owner.Page;
        if (page == null) return;

        page.ClientScript.RegisterStartupScript(owner.GetType(),
            "ShowMessage", string.Format("<script type='text/javascript'>alert('{0}')</script>",
            message));
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}