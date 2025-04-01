using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop
{
    public partial class price : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        price1 cs;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lbl_welcome.Text = "WELCOME!..." + Session["user"];
            }
            else
            {
                Response.Redirect("Logiiin.aspx");
            }
        }
        void getcon()
        {
            cs = new price1();
            cs.startcon();
        }

        protected void Button2_Click(object sender, EventArgs e)//book now
        {
            if (Button1.Text == "Book Now")
            {

                getcon();
                cs.insert(name.Text,email.Text,ddate.Text,tiime.Text,drpprice.SelectedValue);
            }
        }
    }
}