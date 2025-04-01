using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop
{
    public class category2
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
        public DataSet filldata()
        {
            da = new SqlDataAdapter("select * from Cat_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void insert(string pid,string ptype,string pname,string pc,string dec,string img)
        {
            cmd = new SqlCommand("INSERT INTO Cat_tbl(P_id,P_type,P_name,Price_p,Description,image)" + "values('"+pid+"','"+ptype+"','"+pname+"','"+pc+"','"+dec+"','"+img+"')", con);

            cmd.ExecuteNonQuery();
        }
        public void update(int id,string pid, string ptype, string pname,string pc, string dec, string img)
        {
            cmd = new SqlCommand("update Cat_tbl set P_id='" + pid + "',P_type='" + ptype + "',P_name='" + pname + "',Price_p='"+pc+"',Description='" + dec + "',image='" + img + "' where Id='"+id+"'", con);
          


            cmd.ExecuteNonQuery();
        }
        public void delete(int id)//delete code
        {

            cmd = new SqlCommand("delete from Cat_tbl where Id=" + id, con);
            cmd.ExecuteNonQuery();
        }

        public DataSet select(int id)
        {
            da = new SqlDataAdapter("select*from Cat_tbl where Id='" + id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}