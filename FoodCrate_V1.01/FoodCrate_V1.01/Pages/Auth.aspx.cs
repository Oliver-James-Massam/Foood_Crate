using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Configuration;
using FoodCrate_V1._01.Models;

namespace FoodCrate_V1._01.Pages
{
    public partial class Auth : System.Web.UI.Page
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
                
                Uri targetUserUri = new Uri("https://graph.facebook.com/me?fields=first_name,last_name,gender,link,locale,email&access_token=" + accessToken);
                HttpWebRequest user = (HttpWebRequest)HttpWebRequest.Create(targetUserUri);
                
                StreamReader userInfo = new StreamReader(user.GetResponse().GetResponseStream());
                string jsonResponse = string.Empty;
                jsonResponse = userInfo.ReadToEnd();
                
                JavaScriptSerializer sr = new JavaScriptSerializer();
                string jsondata = jsonResponse;
                FackebookStrut.User converted = sr.Deserialize<FackebookStrut.User>(jsondata);

                List<FackebookStrut.User> currentUser = new List<FackebookStrut.User>();
                currentUser.Add(converted);
                ListView1.DataSource = currentUser;
                ListView1.DataBind();
            }
    }
    }
}