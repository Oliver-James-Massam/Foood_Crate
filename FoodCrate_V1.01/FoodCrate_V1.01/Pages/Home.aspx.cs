using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkLogout(object sender, EventArgs e)
        {
            if (Session["login"].Equals(true))
            {
                Session["login"] = false;
                Session["isUser"] = false;
                Session["isAdmin"] = false;
                Session["userID"] = "0";
                Response.Redirect("../Pages/Home.aspx");
            }
            else
            {
                Response.Redirect("../Pages/Login.aspx");
            }
        }
    }
}