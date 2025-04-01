using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop.Admin
{
    public class ser1
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
        public void insert(string pid,string oname,string type,string s1,string s2,string s3,string s4,string s5,string dos,string ser)
        {
            cmd = new SqlCommand("INSERT INTO service_tbl(Pid,Owner_name,Pet_type,S1,S2,S3,S4,s5,Dos,Addservice)" + "VALUES ('"+pid+"','"+oname+"','"+type+"','"+s1+"','"+s2+"','"+s3+"','"+s4+"','"+s5+"','"+dos+"','"+ser+"')", con);

            cmd.ExecuteNonQuery();
        }
    }
}