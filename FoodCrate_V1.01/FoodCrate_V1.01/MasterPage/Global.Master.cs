using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private static bool hasBootUp = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (hasBootUp == false)
            {
                Session["login"] = false;
                Session["isUser"] = false;
                Session["isAdmin"] = false;
                hasBootUp = true;
            }

        }

        protected void checkLogout(object sender, EventArgs e)
        {
            if (Session["login"].Equals(true))
            {
                hasBootUp = false;
                Response.Redirect("../Pages/Home.aspx");
            }
            else
            {
                Response.Redirect("../Pages/Login.aspx");
            }
        }
    }
}