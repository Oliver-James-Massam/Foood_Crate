using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime datetime, DayOfWeek startOfWeek)
        {
            int diffence = datetime.DayOfWeek - startOfWeek;
            if (diffence < 0)
            {
                diffence += 7;
            }
            return datetime.AddDays(-1 * diffence).Date;
        }
    }
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
                    TxtTotalNoSales.InnerText = data.TotalProductsSold().ToString();
                    uniqCust.InnerText = data.TotalRegisteredUsers().ToString();
                    DateTime now = DateTime.Now;
                    var startDateMonth = new DateTime(now.Year, now.Month, 1);
                    var endDateMonth = startDateMonth.AddMonths(1).AddDays(-1);
                    MonthlySales.InnerText = data.CashGenerated(startDateMonth, endDateMonth).ToString();
                    DateTime dtMonday = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                    DateTime dtSunday = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
                    CashThisWeek.InnerText = data.CashGenerated(dtMonday, dtSunday).ToString();
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