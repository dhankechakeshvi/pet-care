using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop.Admin
{
    public class regs1
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
        public void insert(string fn,string ln,string em,string add,string mb)
        {
            cmd = new SqlCommand("INSERT INTO Register_tbl(fname,lname,email,address,mobile)" + "values('"+fn+"','"+ln+"','"+em+"','"+add+"','"+mb+"')", con);

            cmd.ExecuteNonQuery();
        }
        public DataSet filldata()
        {
            da = new SqlDataAdapter("select * from Register_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet select(int id)
        {
            da = new SqlDataAdapter("select*from Register_tbl where Id='" + id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void update(int id, string fn, string ln, string em, string add, string mb)
        {
            cmd = new SqlCommand("update Register_tbl set fname='"+fn+"',lname='"+ln+"',email='"+em+"',address='"+add+"',mobile='"+mb+"'  where Id='" + id + "'", con);
            cmd.ExecuteNonQuery();
        }
        public void delete(int id)
        {
           
            cmd = new SqlCommand("delete from Register_tbl where Id=" + id, con);
            cmd.ExecuteNonQuery();
        }
    }
}