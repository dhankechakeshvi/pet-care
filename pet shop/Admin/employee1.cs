using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace pet_shop.Admin
{
    public class employee1
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
        public void insert(string id, string nm, string gen, string depart, string eml, string mo, string r1, string r2, string r3, string r4, string img)
        {
            cmd = new SqlCommand("INSERT INTO Emp_tbl(Emp_id,Emp_name,Gender,Department,Email,Mobile_no,Role1,Role2,Role3,Role4,Image)" + "values('" + id + "','" + nm + "','" + gen + "','" + depart + "','" + eml + "','" + mo + "','" + r1 + "','" + r2 + "','" + r3 + "','" + r4 + "','" + img + "')", con);

            cmd.ExecuteNonQuery();
        }
        public DataSet filldata()
        {
            da = new SqlDataAdapter("select * from Emp_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet select(int id)
        {
            da = new SqlDataAdapter("select*from Emp_tbl where Id='" + id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void update(int id, string iid, string nm, string gen, string depart, string eml, string mo, string r1, string r2, string r3, string r4, string img)
        {
            cmd = new SqlCommand("update Emp_tbl set Emp_id='" + iid + "',Emp_name='" + nm + "',Gender='" + gen + "',Department='" + depart + "',Email='" + eml + "',Mobile_no='" + mo + "',Role1='" + r1 + "',Role2='" + r2 + "',Role3='" + r3 + "',Role4='" + r4 + "',Image='" + img + "' where Id='" + id + "'", con);
            cmd.ExecuteNonQuery();
        }
        public void delete(int id)
        {

            cmd = new SqlCommand("delete from Emp_tbl where Id=" + id, con);
            cmd.ExecuteNonQuery();
        }
    }
}