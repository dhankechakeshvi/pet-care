using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;


namespace pet_shop
{
    public partial class Reg : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        Class1 cs;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        string fnm, h1, h2, h3;

        string[] hb = new string[3];
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
            //getcon();
            //fillgrid();
        }
        void getcon()
        {
            cs = new Class1();
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
        void hobbies()
        {
            for (int i = 0; i < hb.Length; i++)
            {
                if (chkhobby.Items[i].Selected == true)
                {
                    hb[i] = chkhobby.Items[i].Text;
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Save")
            {
                uploadimg();
                hobbie();
                getcon();

                for (int i = 0; i < 1; i++)
                {
                    if (hb[i] == "Cricket")
                    {
                        h1 = "Cricket";
                        i++;
                    }
                    else
                    {
                        h1 = "Null";
                        i++;
                    }

                    if (hb[i] == "Vollyball")
                    {
                        h2 = "Vollyball";
                        i++;
                    }
                    else
                    {
                        h2 = "Null";
                        i++;
                    }

                    if (hb[i] == "Football")
                    {
                        h3 = "Football";
                        i++;
                    }
                    else
                    {
                        h3 = "Null";
                        i++;
                    }
                }
                cs.insert(name.Text, email.Text, mobile.Text, address.Text, drpcity.SelectedValue, h1, h2, h3, fnm);
            }










            void uploadimg()
            {
                if (fldimg.HasFile)
                {
                    fnm = "image/" + fldimg.FileName;
                    fldimg.SaveAs(Server.MapPath(fnm));
                }
            }
            void hobbie()
            {
                for (int i = 0; i < hb.Length; i++)
                {

                    if (chkhobby.Items[i].Selected == true)
                    {
                        hb[i] = chkhobby.Items[i].Text;
                    }
                }

            }
        }

    }
}
