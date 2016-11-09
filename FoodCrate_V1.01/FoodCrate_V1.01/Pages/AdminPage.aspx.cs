using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser();

        }
        private void CheckUser()
        {
            if (Session["isAdmin"] != null)
            {
                if (Session["isAdmin"].Equals(true))
                {
                    DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
                    cashGen.InnerText = data.TotalSales().ToString();
                    //TxtTotalNoSales.InnerText = data.TotalProductsSold().ToString();
                    //uniqCust.InnerText = data.TotalRegisteredUsers().ToString();
                    //WeeklySaleNo
                    //CashThisWeek To-Do
                    TotalItems.InnerText = data.CountProducts().ToString();
                }
                else
                {
                    Page.Response.Redirect("../Pages/Home.aspx");
                }
            }
            else
            {
                Page.Response.Redirect("../Pages/Home.aspx");
            }
        }
    }
}