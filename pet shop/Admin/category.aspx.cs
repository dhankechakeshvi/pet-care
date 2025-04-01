using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop.Admin
{
    public partial class category : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        category2 cs;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        string fnm;
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
            cs = new category2();
            cs.startcon();
        }
        void imgupload()
        {
            if (fldimg.HasFile)
            {
                fnm = "images/" + fldimg.FileName;
                fldimg.SaveAs(Server.MapPath(fnm));
            }
        }
        void fillgrid()
        {
            cs = new category2();
            getcon();
            GridView1.DataSource = cs.filldata();
            GridView1.DataBind();
        }
        void filltext()
        {
            cs = new category2();
            getcon();
            ds = new DataSet();
            ds = cs.select(Convert.ToInt16(ViewState["id"]));
            pid.Text = ds.Tables[0].Rows[0][1].ToString();
            drptype.Text = ds.Tables[0].Rows[0][2].ToString();
            pname.Text = ds.Tables[0].Rows[0][3].ToString();
            pprice.Text = ds.Tables[0].Rows[0][4].ToString();
            desc.Text = ds.Tables[0].Rows[0][5].ToString();
             
        }
            protected void btn_Click(object sender, EventArgs e)//done button
          {
            if (btn.Text == "Done")
            {
                imgupload();
                getcon();
                cs.insert(pid.Text,drptype.SelectedValue,pname.Text,pprice.Text,desc.Text,fnm);
                fillgrid();
            }
            else
            {
                imgupload();
                getcon();
                cs.update(Convert.ToInt16(ViewState["id"]),
                     pid.Text, drptype.SelectedValue, pname.Text,pprice.Text,desc.Text, fnm);
                fillgrid();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)//gridview
        {
            if (e.CommandName == "cmd_edt")//edit
            {
                int id = Convert.ToInt16(e.CommandArgument);
                ViewState["id"] = id;
                btn.Text = "Update";


                filltext();//paring 
            }
            if (e.CommandName == "cmd_dlt")//delete code
            {
                int id = Convert.ToInt16(e.CommandArgument);
                ViewState["id"] = id;

                cs.delete(id);
                fillgrid();
            }

        }
    }
}