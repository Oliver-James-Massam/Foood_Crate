
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void InfomDatabase(string email, string password)
        {
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
            bool check;
            check = data.UniqueUsername(email);
            if (!check)
            {
                // login current user
                int iRank = data.AuthUser(email, password);

                /// get username and user surname Session["user"] = fb[0].first_name + " " + fb[0].last_name;
                // rank user
                switch (iRank)
                {
                    case 1:
                        Session["isUser"] = true;
                        Session["login"] = true;
                        Page.Response.Redirect("../Pages/Catalog.aspx"); // fix this backdoor
                        break;
                    case 2:
                        Session["isAdmin"] = true;
                        Session["login"] = true;
                        Page.Response.Redirect("../Pages/AdminPage.aspx");
                        break;

                    default:
                        ClientScript.RegisterStartupScript(GetType(), "Error", "alert('User doesnt exist');", true);
                        Page.Response.Redirect("../Pages/Signup.aspx"); 
                        break;
                }

                
            }

            else
            {
                Session["alerUDne"] = true;
                Response.Redirect("../Pages/Signup.aspx");

                
                }
            }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            InfomDatabase(username.Value, password.Value);
        }
    }
    
    
}