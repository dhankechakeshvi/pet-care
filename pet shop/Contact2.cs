using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop
{

    public class Contact2
    {
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public SqlConnection startcon()
        {
            con = new SqlConnection(s);
            con.Open();
            return con;
        }
        public void insert(string nm,string eml,string sub,string msg)
        {
            cmd = new SqlCommand("INSERT INTO contact_tbl(name,email,subject,message)" + "values('"+nm+"','"+eml+"','"+sub+"','"+msg+"')", con);

            cmd.ExecuteNonQuery();
        }

    }

}