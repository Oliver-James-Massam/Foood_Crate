using System;
using System.Configuration;
using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.People.v1;
using Google.Apis.People.v1.Data;
using Google.Apis.Services;
using System.Threading;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
              new ClientSecrets
              {
                  ClientId = ConfigurationManager.AppSettings["GoogleID"],
                  ClientSecret = ConfigurationManager.AppSettings["GoogleSecret"]
              },
              new[] { "profile", "https://www.googleapis.com/auth/contacts.readonly" },
              "me",
              CancellationToken.None).Result;

            // Create the service.
            var service = new PeopleService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "FoodCrateGoogle",
            });

        }
    }

}