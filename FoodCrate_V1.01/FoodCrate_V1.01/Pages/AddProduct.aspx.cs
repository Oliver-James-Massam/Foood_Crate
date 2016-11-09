using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        private string name;
        private string type;
        private int weight;
        private string description;
        private string picture;
        private double price;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isAdmin"].Equals(true))
            {

            }
            else
            {
                Page.Response.Redirect("../Pages/Home.aspx");
            }
        }

        protected void setValueDefault()
        {
            name = "";
            type = "";
            weight = 0;
            description = "";
            picture = "../Images/Food/noimage.jpg";
            price = 0;
        }

        protected void addProduct()
        {
            DatabaseService.DBServiceClient myService = new DatabaseService.DBServiceClient();
            setValueDefault();

            //name = txtName.Value;
            //type = txtType.Value;
            //weight = txtWeight.Value;
        
        }
    }
}