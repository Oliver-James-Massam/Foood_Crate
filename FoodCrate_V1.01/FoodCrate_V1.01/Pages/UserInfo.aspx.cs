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
        DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
        DatabaseService.User userdata;

        protected void Page_Load(object sender, EventArgs e)
        {
            userdata = (DatabaseService.User)Session["AllUserDetails"];
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

        public struct InvoiceItem
        {
            public long invoiceID;
            public long productID;
            public int quantity;
            public int discount;
            public double total;
        }
        protected void displayInvoices()
        {
            long id = userdata.userID;
            List<DatabaseService.Invoice> invoices = new List<DatabaseService.Invoice>();
            //DatabaseService.Invoice[] tempInvoices = data.GetInvoicesByUser(id);
            //foreach (DatabaseService.Invoice tempInvoice in tempInvoices)
            //{
            //    invoices.Add(tempInvoice);
            //}
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