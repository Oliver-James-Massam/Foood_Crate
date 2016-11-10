using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.Pages
{
    public partial class UserInfo : System.Web.UI.Page
    {
        DatabaseService.DBServiceClient data;
        DatabaseService.User userdata;

        protected void Page_Load(object sender, EventArgs e)
        {
            data = new DatabaseService.DBServiceClient();
            if (Session["AllUserDetails"] != null)
            {
                userdata = (DatabaseService.User)Session["AllUserDetails"];
                Emailaddr.InnerHtml = userdata.email;
                dataholder1.InnerHtml = userdata.name + " " + userdata.surname;
            }
            else
            {
                Response.Redirect("Page/Login.aspx");
            }
            }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ChangeName.Value != "")
            {
                if (data.SetUserName(userdata.userID, ChangeName.Value))
                {
                    userdata.name = ChangeName.Value;
                }
            }

            if (SurnameChange.Value != "")
            {
                if (data.SetUserSurname(userdata.userID, SurnameChange.Value))
                {
                    userdata.name = SurnameChange.Value;
                }
            }
        }
    }
}