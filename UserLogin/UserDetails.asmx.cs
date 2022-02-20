using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using MySql.Data.MySqlClient;
namespace UserLogin
{

    [WebService(Namespace = "https://localhost:44354/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]

        public void UserDetailsStores(string FirstName, string LastName, string Emailid, string Qualification, string PhNo, string Country, string State, string City)
        {
            UserDetailsStore UsrDtls = new UserDetailsStore();
            UsrDtls.StorUserDetails(FirstName, LastName, Emailid, Qualification, PhNo, Country, State, City);

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void DisplayUserDetails(String emailid)
        {

            UserDetailsStore uds = new UserDetailsStore();
            string connectionString = "server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";
            string queryString = "SELECT* From userdetails Where emailid = '" + emailid + "' ";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {


                MySqlCommand cmd = new MySqlCommand(queryString, con);
                MySqlParameter param = new MySqlParameter();
                param.ParameterName = "@emailid";
                param.Value = emailid;

                cmd.Parameters.Add(param);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    uds.FirstName = dr["firstname"].ToString();
                    uds.LastName = dr["lastname"].ToString();
                    uds.Emailid = dr["emailid"].ToString();
                    uds.Qualification = dr["qualification"].ToString();
                    uds.PhNo = dr["phno"].ToString();
                    uds.Country = dr["country"].ToString();
                    uds.State = dr["state"].ToString();
                    uds.City = dr["city"].ToString();
                }
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(uds));
        }


        [WebMethod]
        public void DeleteUserAccount(String emailid)
        {
            UserDetailsStore UsrDtls = new UserDetailsStore();
            UsrDtls.DeleteUserDetails(emailid);
        }

        [WebMethod]
        public void UpdateUserDetails(String FirstName, String LastName, String Emailid, String Qualification, string PhNo, string Country, string State, string City)

        {
            UserDetailsStore UsrDtls = new UserDetailsStore();
            UsrDtls.UpdateUserDetails(FirstName, LastName, Emailid, Qualification, PhNo, Country, State, City);

        }
        [WebMethod]
        public void DisplayDataTables()
        {
            using (MySqlConnection con = new MySqlConnection(@"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;"))
            {
                MySqlCommand cmd = new MySqlCommand("select * FROM userdetails", con);

                var UsrsDtils = new List<UserDetailsStore>();
                {
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var uds = new UserDetailsStore
                        {
                            FirstName = dr["firstname"].ToString(),
                            LastName = dr["lastname"].ToString(),
                            Emailid = dr["emailid"].ToString(),
                            Qualification = dr["qualification"].ToString()
                        };
                        UsrsDtils.Add(uds);
                    }
                }
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(UsrsDtils));
            }
        }
        [WebMethod]
        public void Tablecell()
        {
            using (MySqlConnection con = new MySqlConnection(@"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;"))
            {
                MySqlCommand cmd = new MySqlCommand("select * FROM userdetails", con);

                var UsrsDtils = new List<UserDetailsStore>();
                {
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var uds = new UserDetailsStore
                        {
                            FirstName = dr["firstname"].ToString(),
                            LastName = dr["lastname"].ToString(),
                            Emailid = dr["emailid"].ToString(),
                            Qualification = dr["qualification"].ToString(),
                            PhNo = dr["phno"].ToString(),
                            Country = dr["country"].ToString(),
                            State = dr["state"].ToString(),
                            City = dr["city"].ToString()
                        };
                        UsrsDtils.Add(uds);
                    }
                }
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(UsrsDtils));
            }
        }
    }

 }
