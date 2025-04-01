using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;


namespace pet_shop.Admin
{
    public partial class servicee : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        ser1 cs;
        string s = ConfigurationManager.ConnectionStrings["dbconnect"].ToString();
        string fnm, s1, s2, s3, s4, s5;
        string[] rb = new string[5];
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
            // fillgrid();
        }
        void getcon()
        {
            cs = new ser1();
            cs.startcon();
        }
        void role()
        {
            for (int i = 0; i < rb.Length; i++)
            {

                if (chkservice.Items[i].Selected == true)
                {
                    rb[i] = chkservice.Items[i].Text;
                }
            }
        }
        protected void btn_Click(object sender, EventArgs e)
        {
            if (btn.Text == "Done")
            {
                getcon();
                //imgupload();
                role();

                for (int i = 0; i < 1; i++)
                {
                    if (rb[i] == "PetTraining")
                    {
                        s1 = "PetTraining";
                        i++;
                    }
                    else
                    {
                        s1 = "Null";
                        i++;
                    }

                    if (rb[i] == "PetDaycare")
                    {
                        s2 = "PetDaycare";
                        i++;
                    }
                    else
                    {
                        s2 = "Null";
                        i++;
                    }

                    if (rb[i] == "VeterinaryCheckups")
                    {
                        s3 = "VeterinaryCheckups";
                        i++;
                    }
                    else
                    {
                        s3 = "Null";
                        i++;
                    }
                    if (rb[i] == "PetWalking")
                    {
                        s4 = "PetWalking";
                        i++;
                    }
                    else
                    {
                        s4 = "Null";
                        i++;
                    }
                    if (rb[i] == "PetPhotography")
                    {
                        s5 = "PetPhotography";
                        i++;
                    }
                    else
                    {
                        s5 = "Null";
                        i++;
                    }
                }
                cs.insert(pid.Text,name.Text,type.Text,s1,s2,s3,s4,s5,dos.Text,add.Text);
                // fillgrid();
            }
        }
    }
}