using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
namespace pet_shop.Admin
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        employee1 cs;
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void getcon()
        {
            cs = new employee1();
            cs.startcon();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("select count(*) from Emp_tbl where " +
                "Email='" +lname.Text + "'" +
                " and Mobile_no='" +lpass.Text + "'", cs.startcon());
            i = Convert.ToInt16(cmd.ExecuteScalar());

            if (i > 0)
            {
                Session["user"] = lname.Text;
                Response.Redirect("category.aspx");
            }

        }
    }
}