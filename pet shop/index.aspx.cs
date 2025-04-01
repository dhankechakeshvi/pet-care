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
    public partial class index : System.Web.UI.Page
    {
        
      
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        index2 cs;
        PagedDataSource pg;
        int p,pid, row;

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
            display();

        }
        void getcon()
        {
            cs = new index2();
            cs.startcon();
            LinkButton4.Enabled = true;
        }
        void display()
        {
            da = new SqlDataAdapter("select * from Emp_tbl", cs.startcon());
            ds = new DataSet();
            da.Fill(ds);
            row = ds.Tables[0].Rows.Count;
            pg = new PagedDataSource();
            pg.AllowPaging = true;
            pg.PageSize = 4;
            pg.DataSource = ds.Tables[0].DefaultView;
            pg.CurrentPageIndex = Convert.ToInt32(ViewState["pid"]);
            DataList1.DataSource = pg;
            DataList1.DataBind();
        }


       


        protected void btn_Click(object sender, EventArgs e)
        {
            //if (Button1.Text == "Submit Now")
            //{

            //    getcon();
            //    cs.insert(name.Text, email.Text);
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //if (Button1.Text == "Book Now")
            //{

            //    getcon();
            //    cs.insert(name.Text, email.Text, ddate.Text, tiime.Text, drpprice.SelectedValue);
            //}
        }

        protected void LinkButton3_Click(object sender, EventArgs e)//previous
        {
            LinkButton3.Enabled = true;
            p += Convert.ToInt32(ViewState["pid"]) - 1;
            ViewState["pid"] = Convert.ToInt32(p);

            if (p == 0)
            {
                LinkButton3.Enabled = false;
            }
            display();


        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton5_Command(object sender, CommandEventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)//view details.....
        {
            if (e.CommandName == "cmd_viewdet")
            {
                int id = (Convert.ToInt32(e.CommandArgument));
                Response.Redirect("view_detaills.aspx?id=" + id);

            }

        }
     


        protected void LinkButton4_Click(object sender, EventArgs e)//next
        {
            LinkButton3.Enabled = true;

            p += Convert.ToInt32(ViewState["pid"]) + 1;
            ViewState["pid"] = Convert.ToInt32(p);
            int temp = row / pg.PageSize;
            if (p == temp)
            {
                LinkButton4.Enabled = false;
            }
            display();

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}