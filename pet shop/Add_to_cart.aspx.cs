using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace pet_shop
{
    public partial class Add_to_cart : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        addtocart1 cs;
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
            getcon();
            displays();

        }

        void getcon()
        {
            cs = new addtocart1();
            cs.startcon();
        }

        void displays()
        {
            if (Convert.ToInt16(Request.QueryString["id"]) != 0)
            {
                //int id = Convert.ToInt16(Request.QueryString["id"]);
                getcon();
                da = new SqlDataAdapter("Select * from Cat_tbl Where id='" + Request.QueryString["id"] + "' ", cs.startcon());
                ds = new DataSet();
                da.Fill(ds);
               DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)//BUY  NOW
        {
            if (e.CommandName == "cmd_Buy")
            {
                int id = (Convert.ToInt32(e.CommandArgument));
                Response.Redirect("Buy_Now.aspx?id=" + id);

            }
        }
    }
}