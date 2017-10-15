using System;
using System.Collections.Generic;
using System.Globalization;
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

        protected void setFieldDefault()
        {
            txtName.Value = "";
            txtType.Value = "";
            txtWeight.Value = "500";
            txtDescription.Value = "";
            picture = "noimage.jpg";
            txtPrice.Value = "49.99";
        }

        protected void addProduct(object sender, EventArgs e)
        {
            try
            {
                DatabaseService.DBServiceClient myService = new DatabaseService.DBServiceClient();
                setValueDefault();

                name = txtName.Value;
                type = txtType.Value;
                weight = Convert.ToInt32(txtWeight.Value);
                description = txtDescription.Value;
                if (!(txtPicture.Value.Equals("")) || txtPicture.Value != null || txtPicture.Value.Equals("noimage.jpg"))
                {
                    picture = "../Images/Food/" + txtPicture.Value;
                }
                price = double.Parse(txtPrice.Value, System.Globalization.CultureInfo.InvariantCulture);
            
                long result = myService.AddProduct(name, type, weight, description, picture, price);
                if (result > 0)
                    setFieldDefault();
                else
                    txtName.Value = "" + result;
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (InvalidCastException iex)
            {
                Console.WriteLine(iex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}