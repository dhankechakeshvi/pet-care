using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace pet_shop.Admin
{
    public partial class employee : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        employee1 cs;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        string fnm, r1, r2, r3, r4;
        string[] rb = new string[4];
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmd_edt")
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
        void filltext()
        {
            cs = new employee1();
            getcon();
            ds = new DataSet();
            ds = cs.select(Convert.ToInt16(ViewState["id"]));
            id.Text = ds.Tables[0].Rows[0][1].ToString();
            name.Text = ds.Tables[0].Rows[0][2].ToString();
            //gender
            if (ds.Tables[0].Rows[0][3].ToString() == "Male")
            {
                rdbgender.Items[0].Selected = true;
            }
            if (ds.Tables[0].Rows[0][3].ToString() == "Female")
            {
                rdbgender.Items[0].Selected = true;
            }
           depart.Text = ds.Tables[0].Rows[0][4].ToString();
            email.Text = ds.Tables[0].Rows[0][5].ToString();
            phone.Text = ds.Tables[0].Rows[0][6].ToString();
            //role
            if (ds.Tables[0].Rows[0][7].ToString() == "Doctor")
            {
                chkrole.Items[0].Selected = true;
            }
            else
            {
                chkrole.Items[0].Selected = false;
            }

            if (ds.Tables[0].Rows[0][8].ToString() == "Founder & CEO")
            {
                chkrole.Items[1].Selected = true;
            }
            else
            {
                chkrole.Items[1].Selected = false;
            }

            if (ds.Tables[0].Rows[0][9].ToString() == "Chef Executiv")
            {
                chkrole.Items[2].Selected = true;
            }
            else
            {
                chkrole.Items[2].Selected = false;
            }
            if (ds.Tables[0].Rows[0][10].ToString() == "Trainer")
            {
                chkrole.Items[3].Selected = true;
            }
            else
            {
                chkrole.Items[3].Selected = false;
            }
        }
            void getcon()
            {
                cs = new employee1();
                cs.startcon();
            }
        void fillgrid()
        {
            cs = new employee1();
            getcon();
            GridView1.DataSource = cs.filldata();
            GridView1.DataBind();
        }
        void imgupload()
            {
                if (fldimg.HasFile)
                {
                    fnm = "images/" + fldimg.FileName;
                    fldimg.SaveAs(Server.MapPath(fnm));
                }
            }
            void role()
            {
                for (int i = 0; i < rb.Length; i++)
                {

                    if (chkrole.Items[i].Selected == true)
                    {
                        rb[i] = chkrole.Items[i].Text;
                    }
                }
            }
            protected void btn_Click(object sender, EventArgs e)
            {
                if (btn.Text == "Submit")
                {
                    getcon();
                    imgupload();
                    role();

                    for (int i = 0; i < 1; i++)
                    {
                        if (rb[i] == "Doctor")
                        {
                            r1 = "Doctor";
                            i++;
                        }
                        else
                        {
                            r1 = "Null";
                            i++;
                        }

                        if (rb[i] == "Founder & CEO")
                        {
                            r2 = "Founder & CEO";
                            i++;
                        }
                        else
                        {
                            r2 = "Null";
                            i++;
                        }

                        if (rb[i] == "Chef Executive")
                        {
                            r3 = "Chef Executive";
                            i++;
                        }
                        else
                        {
                            r3 = "Null";
                            i++;
                        }
                        if (rb[i] == "Trainer")
                        {
                            r4 = "Trainer";
                            i++;
                        }
                        else
                        {
                            r4 = "Null";
                            i++;
                        }
                    }
                    cs.insert(id.Text, name.Text, rdbgender.Text, depart.Text, email.Text, phone.Text, r1, r2, r3, r4, fnm);
                fillgrid();
                }
            else
            {
                getcon();
                imgupload();
                role();
                for (int i = 0; i < 1; i++)
                {
                    if (rb[i] == "Doctor")
                    {
                        r1 = "Doctor";
                        i++;
                    }
                    else
                    {
                        r1 = "Null";
                        i++;
                    }

                    if (rb[i] == "Founder & CEO")
                    {
                        r2 = "Founder & CEO";
                        i++;
                    }
                    else
                    {
                        r2 = "Null";
                        i++;
                    }

                    if (rb[i] == "Chef Executive")
                    {
                        r3 = "Chef Executive";
                        i++;
                    }
                    else
                    {
                        r3 = "Null";
                        i++;
                    }
                    if (rb[i] == "Trainer")
                    {
                        r4 = "Trainer";
                        i++;
                    }
                    else
                    {
                        r4 = "Null";
                        i++;
                    }
                }
                cs.update(Convert.ToInt16(ViewState["id"]), id.Text,name.Text,rdbgender.Text,depart.Text,email.Text,phone.Text,r1,r2,r3,r4,fnm);
                fillgrid();
            }
          }
        }
    }
