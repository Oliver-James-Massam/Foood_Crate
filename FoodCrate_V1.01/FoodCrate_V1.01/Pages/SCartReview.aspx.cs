using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        double value = 10;
        double discount = 10;
        protected void Page_Load(object sender, EventArgs e)
        {
            value = double.Parse(Request.QueryString["Total"]);
            FaceVal.Text = value.ToString();
            Tax.Text = (value * 0.14).ToString();
            if (value < 300)
            {
                Shipping.Text = "Not free - R " + value*0.05;
                discount = value * 0.05;
                Total.Text = "R: " + (value * 0.14 + value * 0.05 + value).ToString();
            }
            else
            {
                Shipping.Text = "Free";
                discount = 0;
                Total.Text = "R:" + (value * 0.14 + value).ToString();
            }

         }
        protected void Accept_Click(object sender, EventArgs e)
        {
            // add invoice
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
            DatabaseService.User userdata = (DatabaseService.User)Session["AllUserDetails"];
            long worked = data.AddInvoice(userdata.userID);

            List<long> itemsID = (List<long>)Session["itemsIdScart"];
            List<int> Quantit = (List<int>)Session["QuantitScart"];
            //
            //Session["QuantitScart"]
            // add all items
            for (int i = 0; i < itemsID.Count; i++)
                data.AddInvoiceItem(worked, itemsID[i], Quantit[i], (int)discount, value);

            Response.Redirect("../Pages/ScartCheckOut.aspx");
        }
    }
}