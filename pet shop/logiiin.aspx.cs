using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop
{
    public partial class logiiin : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        Contact2 cs;
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void getcon()
        {
            cs = new Contact2();
            cs.startcon();
        }
        protected void Btn_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("select count(*) from reeg_tbl where " +
                "email='" + cname.Text + "'" +
                " and mobile='" + cpass.Text + "'", cs.startcon());
            i = Convert.ToInt16(cmd.ExecuteScalar());

            if (i > 0)
            {
                Session["user"] = cname.Text;
                Response.Redirect("index.aspx");
            }
        }
    }
}