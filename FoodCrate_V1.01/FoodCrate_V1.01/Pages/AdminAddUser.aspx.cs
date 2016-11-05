using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser();

        }
        private void CheckUser()
        {
            if (Session["isAdmin"] != null)
            {
                if (Session["isAdmin"].Equals(true))
                {

                }
                else
                {
                    Page.Response.Redirect("../Pages/Home.aspx");
                }
            }
            else
            {
                Page.Response.Redirect("../Pages/Home.aspx");
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Database.DataCsharpClient data = new Database.DataCsharpClient();
            int userPriv = 1;
            if (CheckIsAdmin.Checked)
            {
                userPriv = 2;
            }
            else
            {
                userPriv = 1;
            }
            data.AddUser(input_email.Value, input_name.Value, input_lastname.Value, input_email.Value, userPriv, input_password.Value);
        }
    }
}