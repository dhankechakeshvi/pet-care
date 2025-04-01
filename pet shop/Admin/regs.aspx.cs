using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop.Admin
{
    public partial class regs : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        regs1 cs;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
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
            cs = new regs1();
            cs.startcon();
        }
        void fillgrid()
        {
            cs = new regs1();
            getcon();
            GridView1.DataSource = cs.filldata();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Register")
            {

                getcon();
                cs.insert(fname.Text, lname.Text, email.Text, address.Text, mobile.Text);
                fillgrid();
            }
            else
            {
                cs = new regs1();
                getcon();
                cs.update(Convert.ToInt16(ViewState["id"]),fname.Text,lname.Text,email.Text,address.Text,mobile.Text);
                fillgrid();

                
                //empty();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmd_edt")
            {
                int id = Convert.ToInt16(e.CommandArgument);
                ViewState["id"] = id;
                Button1.Text = "Update";


                filltext();
            }
            else
            {
                cs.delete(Convert.ToInt16(ViewState["id"]));
                fillgrid();
            }
        }
        void filltext()
        {
            cs = new regs1();
            getcon();
            ds = new DataSet();
            ds = cs.select(Convert.ToInt16(ViewState["id"]));




            fname.Text = ds.Tables[0].Rows[0][1].ToString();
            lname.Text = ds.Tables[0].Rows[0][2].ToString();
            email.Text = ds.Tables[0].Rows[0][3].ToString();
            address.Text = ds.Tables[0].Rows[0][4].ToString();
            mobile.Text = ds.Tables[0].Rows[0][5].ToString();
        }
        void empty()
        {
           fname.Text = "";
            lname.Text = "";
            email.Text = "";
            address.Text = "";
            mobile.Text = "";
            Button1.Text = "Save";
        }
    }
}