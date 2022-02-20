using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;


namespace UserLogin
{

    public class UserDetailsStore
    {
        public object FirstName { get;  set; }
        public object LastName { get;  set; }
        public object Emailid { get;  set; }
        public object Qualification { get;  set; }
        public object PhNo { get; set; }
        public object Country { get; set; }
        public object State { get; set; }
        public object City { get; set; }


        public void StorUserDetails(string FirstName, string LastName, string Emailid, string Qualification, string PhNo, string Country, string State, string City)
        {
            string connectionString = "server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT into userdetails(FirstName, LastName,Emailid,Qualification,PhNo,Country,State,City) VALUES (@firstname, @lastname, @emailid, @qualification, @phno, @country, @state, @city)", con);
            cmd.Parameters.AddWithValue("@firstname", FirstName);
            cmd.Parameters.AddWithValue("@lastname", LastName);
            cmd.Parameters.AddWithValue("@emailid", Emailid);
            cmd.Parameters.AddWithValue("@qualification", Qualification);
            cmd.Parameters.AddWithValue("@phno", PhNo);
            cmd.Parameters.AddWithValue("@country", Country);
            cmd.Parameters.AddWithValue("@state", State);
            cmd.Parameters.AddWithValue("@city", City);
            cmd.ExecuteNonQuery();

        }
        public void DeleteUserDetails(String Emailid)
        {
            string connectionString = "server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";

            MySqlConnection con = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("DELETE  from userdetails where emailid = '" + Emailid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void UpdateUserDetails(string FirstName, string LastName, string Emailid, string Qualification, string PhNo, string Country, string State, string City)
        {
            string connectionString = "server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string queryString = "UPDATE userdetails SET FirstName = @firstname, LastName = @lastname, Emailid = @emailid, Qualification = @qualification,PhNo = @phno,Country=@country,State =@state,City=@city WHERE Emailid = @emailid";
             MySqlCommand cmd = new MySqlCommand(queryString, con);
            cmd.Parameters.AddWithValue("@firstname", FirstName);
            cmd.Parameters.AddWithValue("@lastname", LastName);
            cmd.Parameters.AddWithValue("@emailid", Emailid);
            cmd.Parameters.AddWithValue("@qualification", Qualification);
            cmd.Parameters.AddWithValue("@phno", PhNo);
            cmd.Parameters.AddWithValue("@country", Country);
            cmd.Parameters.AddWithValue("@state", State);
            cmd.Parameters.AddWithValue("@city", City);
            cmd.ExecuteNonQuery();

        }

    }


}