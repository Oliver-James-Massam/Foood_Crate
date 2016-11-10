using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        long prodID = 0;
        DatabaseService.Product product = new DatabaseService.Product();
        DatabaseService.DBServiceClient myService = new DatabaseService.DBServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                prodID = Int64.Parse(Request.QueryString["productID"]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            setPage();
        }

        protected void addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["login"].Equals(false))
            {
                Response.Redirect("../Pages/Login.aspx");
            }
            else
            {
                int quantity = Convert.ToInt32(txtQuantity.Value);
                DatabaseService.User userdata = (DatabaseService.User)Session["AllUserDetails"];
                long tempID = userdata.userID; 
                long result = myService.AddCart(tempID, product.productID, quantity);
                if (result > 0)
                    Buy.InnerHtml = "Successfully Added to Cart";
                else
                    Buy.InnerHtml = "Item No Longer Exists";
            }
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

        protected void setPage()
        {
            if(prodID != 0)
            {
                DatabaseService.Product emptyProduct = new DatabaseService.Product();
                emptyProduct = initProduct(emptyProduct);

                product = initProduct(product);
                try
                {
                    product = myService.GetProduct(prodID);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (!product.Equals(emptyProduct))
                    {
                        prodDetails.InnerHtml =
                                                            "<img class='img-responsive' src='" + product.picture + "' alt=''/>" +
                                                            "<div class='caption-full' >" +
                                                                "<h3 class='pull-right' id='Price' style='color: #B20000;'>R" + (Math.Round(product.price, 2)).ToString("#.00", CultureInfo.InvariantCulture) + "</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Name: </span>" + product.name + "</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Type: </span>" + product.type + "</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Weight: </span>" + product.weight + "g</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Description: </span>" + product.description + "</h3>" +
                                                            "</div>" +
                                                        "<br/>";                                                     
                    }
                }
            }
        }

        protected DatabaseService.Product initProduct(DatabaseService.Product tempProd)
        {
            tempProd.productID = 0;
            tempProd.name = "";
            tempProd.type = "";
            tempProd.weight = 0;
            tempProd.description = "";
            tempProd.picture = "";
            tempProd.price = 0;
            return tempProd;
        }

        
    }
}