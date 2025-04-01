using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop
{
    public partial class booking : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        Book1 cs;
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
            cs = new Book1();
            cs.startcon();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            if (Btn.Text == "Book Now")
            {

                getcon();
                cs.insert(name.Text,email.Text,ddate.Text,tiime.Text,drpservice.SelectedValue);
            }
        }
    }
}