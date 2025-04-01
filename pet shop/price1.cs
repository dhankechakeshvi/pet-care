using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop
{
    public class price1
    {
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public void startcon()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        public void insert(string nm,string eml,string date,string time,string price)
        {
            cmd = new SqlCommand("INSERT INTO price_tbl(name,email,date,time,price)" + "values('"+nm+"','"+eml+"','"+date+"','"+time+"','"+price+"')", con);

            cmd.ExecuteNonQuery();
        }

    }
}