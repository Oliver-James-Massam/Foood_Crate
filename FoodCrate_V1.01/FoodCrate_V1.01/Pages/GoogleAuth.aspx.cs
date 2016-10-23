using System;
using ASPSnippets.GoogleAPI;
using System.Web.Script.Serialization;
using FoodCrate_V1._01.Models;
using System.Configuration;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Login(object sender, EventArgs e)
        {
            GoogleConnect.Authorize("profile", "email");
        }

        protected void Clear(object sender, EventArgs e)
        {
            GoogleConnect.Clear();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GoogleConnect.ClientId = ConfigurationManager.AppSettings["GoogleID"];
            GoogleConnect.ClientSecret = ConfigurationManager.AppSettings["GoogleSecret"];
            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

            if (!string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                string code = Request.QueryString["code"];
                string json = GoogleConnect.Fetch("me", code);
                Models.googleStruct profile = new JavaScriptSerializer().Deserialize<googleStruct>(json);
                lblId.Text = profile.Id;
                lblName.Text = profile.DisplayName;
                lblEmail.Text = profile.Emails.Find(email => email.Type == "account").Value;
                lblGender.Text = profile.Gender;
                lblType.Text = profile.ObjectType;
                ProfileImage.ImageUrl = profile.Image.Url;
                pnlProfile.Visible = true;
                btnLogin.Enabled = false;
            }
            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }
        }
    }

}