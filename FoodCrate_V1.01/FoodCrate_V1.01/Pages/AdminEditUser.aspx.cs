using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm6 : System.Web.UI.Page
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
                    // dont redirect
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
            if (ChangeName.Value != "")
            {

            }
           // if (SurnameChange)
        }
    }
}