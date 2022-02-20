using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{
    //***********************************/
    //		DATABASE FUNCTIONS
    //***********************************/
    static public string DatabaseConnString()
    {
        string ConnStr = (string)System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        return ConnStr;
    }

    static public string MildewDatabaseConnString()
    {
        string ConnStr = (string)System.Configuration.ConfigurationManager.AppSettings["MildewConnectionString"];
        return ConnStr;
    }

    static public string ProductionTrackerDatabaseConnString()
    {
        string ConnStr = (string)System.Configuration.ConfigurationManager.AppSettings["ProductionTrackerConnectionString"];
        return ConnStr;
    }

    static public string USFabDatabaseConnectionString()
    {
        string FabConnStr = (string)System.Configuration.ConfigurationManager.AppSettings["FabricationConnectionString"];
        return FabConnStr;
    }

    static public string CareDatabaseConnectionString()
    {
        string ConnStr = (string)System.Configuration.ConfigurationManager.AppSettings["CareConnectionString"];
        return ConnStr;
    }
}