using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["cart"] != null)
            {

            }else
            {
                Response.Redirect("../Pages/Catalog.aspx");
            }
        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/SCartReview.aspx");
        }
    }
}