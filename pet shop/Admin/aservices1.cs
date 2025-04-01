using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop.Admin
{
    public class aservices1
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

        public DataSet filldata()
        {
            da = new SqlDataAdapter("select * from Book_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
    }
}