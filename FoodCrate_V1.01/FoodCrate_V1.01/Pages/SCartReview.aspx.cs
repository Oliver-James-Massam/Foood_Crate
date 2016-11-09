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
        protected void Page_Load(object sender, EventArgs e)
        {
            // value = double.Parse(Request.QueryString["Total"]);
            FaceVal.Text = value.ToString();
            Tax.Text = (value * 0.14).ToString();
            if (value < 300)
            {
                Shipping.Text = "Not free - R" + value*0.05;
                Total.Text = (value * 0.14 + value * 0.05 + value).ToString();
            }
            else
            {
                Shipping.Text = "Free";
                Total.Text = (value * 0.14 + value * 0.05 + value).ToString();
            }

         }
        protected void Accept_Click(object sender, EventArgs e)
        {
            // add invoice

            Response.Redirect("../Pages/ScartCheckOut.aspx");
        }
    }
}