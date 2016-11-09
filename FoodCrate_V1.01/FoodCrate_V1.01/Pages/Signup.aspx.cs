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
            if (Password.Value == Repassword.Value) { 

                DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
                data.AddUser(Username.Value, FirstName.Value, Surname.Value, Email.Value, 1, Password.Value);
                int iRank = data.AuthUser(Email.Value, Password.Value);
                DatabaseService.User userdata = new DatabaseService.User();
                userdata = data.GetUser(Email.Value, Password.Value);
                Session["AllUserDetails"] = userdata;
                Session["user"] = FirstName.Value + " " + Surname.Value;
                // rank user
                switch (iRank)
                {
                    case 1:
                        Session["isUser"] = true;
                        Session["login"] = true;
                        Page.Response.Redirect("../Pages/Catalog.aspx");
                        break;
                    case 2:
                        Session["isAdmin"] = true;
                        Session["login"] = true;
                        Page.Response.Redirect("../Pages/AdminPage.aspx");
                        break;
                    default:
                        Page.Response.Redirect("../Pages/Catalog.aspx");
                        break;
                }
            }
        }
    }
}