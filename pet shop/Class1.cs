using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop
{
    public class Class1
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

        public void insert(string nm, string eml, string mbl, string add, string ct, string hh1, string hh2, string hh3, string img)
        {
            cmd = new SqlCommand("insert into reeg_tbl(name,email,mobile,address,city,hh1,hh2,hh3,image)" + "values('" + nm + "','" + eml + "','" + mbl + "','" + add + "','" + ct + "','" + hh1 + "','" + hh2 + "','" + hh3 + "','" + img + "')", con);

            cmd.ExecuteNonQuery();
        }

        public static implicit operator Class1(Contact2 v)
        {
            throw new NotImplementedException();
        }
    }
}

