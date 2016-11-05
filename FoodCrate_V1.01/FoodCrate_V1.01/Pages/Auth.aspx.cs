using FoodCrate_V1._01.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkFBAuth();
        }

        private void checkFBAuth()
        {

            String id = ConfigurationManager.AppSettings["FacebookID"];
            String app_secret = ConfigurationManager.AppSettings["FaceSecret"];

            if (Request.QueryString["code"] != "")
            {

                Uri destuUi = new Uri("https://graph.facebook.com/oauth/access_token?client_id=" + id + "&client_secret=" + app_secret + "&redirect_uri=http://" + Request.ServerVariables["SERVER_NAME"] + ":" + Request.ServerVariables["SERVER_PORT"] + "/Pages/Auth.aspx&code=" + Request.QueryString["code"]);
                HttpWebRequest httpReq = (HttpWebRequest)HttpWebRequest.Create(destuUi);
                System.IO.StreamReader reader = new System.IO.StreamReader(httpReq.GetResponse().GetResponseStream());
                string token = reader.ReadToEnd().ToString().Replace("access_token=", "");
                string[] combined = token.Split('&');
                string accessToken = combined[0];
                Uri eatTargetUri = new Uri("https://graph.facebook.com/oauth/access_token?grant_type=fb_exchange_token&client_id=" + id + "&client_secret=" + app_secret + "&fb_exchange_token=" + accessToken); HttpWebRequest eat = (HttpWebRequest)HttpWebRequest.Create(eatTargetUri);

                StreamReader eatStr = new StreamReader(eat.GetResponse().GetResponseStream());
                string eatToken = eatStr.ReadToEnd().ToString().Replace("access_token=", "");

                string[] eatWords = eatToken.Split('&');
                string extendedAccessToken = eatWords[0];

                Uri targetUserUri = new Uri("https://graph.facebook.com/me?fields=first_name,last_name,link,email&access_token=" + accessToken);
                HttpWebRequest user = (HttpWebRequest)HttpWebRequest.Create(targetUserUri);

                StreamReader userInfo = new StreamReader(user.GetResponse().GetResponseStream());
                string jsonResponse = string.Empty;
                jsonResponse = userInfo.ReadToEnd();

                JavaScriptSerializer sr = new JavaScriptSerializer();
                string jsondata = jsonResponse;
                FackebookStrut.User converted = sr.Deserialize<FackebookStrut.User>(jsondata);

                List<FackebookStrut.User> currentUser = new List<FackebookStrut.User>();
                currentUser.Add(converted);
                InfomDatabase(currentUser);
                ListView1.DataSource = currentUser;
                ListView1.DataBind();
            }
        }


        //oliver look at this
        private void InfomDatabase(List<FackebookStrut.User> fb)
        {
           Database.DataCsharpClient data = new Database.DataCsharpClient() ;
            Boolean check;
            check = data.UniqueUsername(fb[0].email);
            if (check)
            {
                // login current user
                ///int iRank = data.AuthUser(fb[0].email, fb[0].link);
                int iRank = data.AuthUser("StopDickingAroundWithTheGoogleAPI@gmail.com", "asdf");
                // rank user
                switch (iRank)
                {
                    case 1:
                        Page.Response.Redirect("../Pages/AdminPage.aspx"); // fix this backdoor
                        Session["isAdmin"] = true;
                        break;
                    case 2:
                        Session["isAdmin"] = true;
                        Page.Response.Redirect("../Pages/AdminPage.aspx");
                        break;

                    default:
                        Page.Response.Redirect("../Pages/Catalog.aspx");
                        break;
                }
                

                // rank admin
                
            }

            else
            {
                // create a new user
                data.AddUser(fb[0].email, fb[0].first_name, fb[0].last_name, fb[0].email, 1, fb[0].link);
                int iRank = data.AuthUser(fb[0].email, fb[0].link);
                // rank user
                switch (iRank)
                {
                    case 1:
                        Page.Response.Redirect("../Pages/Catalog.aspx");
                        break;
                    case 2:
                        Session["isAdmin"] = true;
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
