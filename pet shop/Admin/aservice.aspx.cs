using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace pet_shop.Admin


{
    public partial class aservice : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        aservices1 ct;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lbl_welcome.Text = "WELCOME!..." + Session["user"];
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            getcon();
            fillgrid();
        }
        void getcon()
        {
            ct = new aservices1();
            ct.startcon();

        }

        void fillgrid()
        {
            ct = new aservices1();
            getcon();
            GridView1.DataSource = ct.filldata();
            GridView1.DataBind();
        }
    }
}