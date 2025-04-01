using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop
{
    public partial class contact : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        Contact2 cs;
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
            cs = new Contact2();
            cs.startcon();
        }
        //protected void TextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Submit")
            {

                getcon();
                cs.insert(name.Text, email.Text, subject.Text, message.Text);
            }
           
        }
    }
}