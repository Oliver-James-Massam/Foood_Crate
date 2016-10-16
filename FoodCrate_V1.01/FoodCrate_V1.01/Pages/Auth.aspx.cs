using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            String id = ConfigurationManager.ConnectionStrings["FacebookID"].ConnectionString;
            String app_secret = ConfigurationManager.ConnectionStrings["FaceSecret"].ConnectionString;
            String scope = "public_profile,email,";

            if (Request["code"] == null)
            {
                Response.Redirect(string.Format("https://graph.facebook.com/oauth/authorize?client_id={0}&redirect_uri={1}&scope={2}",
                    id, Request.Url.AbsoluteUri, scope));

            }
            else
            {
                Dictionary<string, string> tok = new Dictionary<string, string>(); // collections Generics 
                string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}", id, Request.Url.AbsoluteUri, scope, Request["code"].ToString(), app_secret); // from facebook doccumentation
                HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest; // .net

                using (HttpWebResponse rep = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader read = new StreamReader(rep.GetResponseStream());

                    string returns = read.ReadToEnd();

                    foreach (string token in returns.Split('&'))
                    {
                       tok.Add(token.Substring(0, token.IndexOf("=")),
                       token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=") - 1));
                    }
                }
                string access_token = tok["access_token"];

                //getting email
                tok = new Dictionary<string, string>(); // collections Generics 
                url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}", id, Request.Url.AbsoluteUri, scope, Request["code"].ToString(), app_secret); // from facebook doccumentation
                req = WebRequest.Create(url) as HttpWebRequest; // .net
                using (HttpWebResponse rep = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader read = new StreamReader(rep.GetResponseStream());

                    string returns = read.ReadToEnd();

                    foreach (string token in returns.Split('&'))
                    {
                        tok.Add(token.Substring(0, token.IndexOf("=")),
                        token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=") - 1));
                    }
                }
                //string email = tok["email"];
                //string fbId = tok["id"];
                //string first_name = tok["first_name"];
                //string last_name = tok["last_name"];
                //   string picture = tok["access_token"];
                //  string access_token = tok["access_token"]; // this is needed to get that sweet access token if we imp sharing



            }
        }
    }
}