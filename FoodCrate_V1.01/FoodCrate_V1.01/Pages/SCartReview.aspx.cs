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
            Tax.Text = Math.Round(value * 0.14,2).ToString();
            if (value < 300)
            {
                Shipping.Text = "R " + Math.Round(value *0.05);
                discount = Math.Round(value * 0.05,2);
                Total.Text = "R: " + Math.Round(value * 0.14 + value * 0.05 + value,2).ToString();
            }
            else
            {
                Shipping.Text = "Free";
                discount = 0;
                Total.Text = "R:" + Math.Round(value * 0.14 + value,2).ToString();
            }

         }
        protected void Accept_Click(object sender, EventArgs e)
        {
            // add invoice
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
            DatabaseService.User userdata = (DatabaseService.User)Session["AllUserDetails"];
            long worked = data.AddInvoice(userdata.userID);

            List<DatabaseService.Cart> ListCart = (List<DatabaseService.Cart>)Session["cartList"];
            //
            //Session["QuantitScart"]
            // add all items
            for (int i = 0; i < ListCart.Count; i++) { 
            data.AddInvoiceItem(worked, ListCart[i].productID, ListCart[i].quantity, (int)discount, value);
                data.RemoveCartItem(ListCart[i].cartID);
                }
            
            Response.Redirect("../Pages/ScartCheckOut.aspx");
        }
    }
}