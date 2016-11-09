using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["alerUDne"] != null)
                ClientScript.RegisterStartupScript(GetType(), "Error", "alert('User doesnt exist');", true);
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {

        }
    }
}