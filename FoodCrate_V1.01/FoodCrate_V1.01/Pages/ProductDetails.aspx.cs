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

        protected void setPage()
        {
            if(prodID != 0)
            {
                DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
                DatabaseService.Product emptyProduct = new DatabaseService.Product();
                emptyProduct = initProduct(emptyProduct);

                DatabaseService.Product product = new DatabaseService.Product();
                product = initProduct(product);
                try
                {
                    product = data.GetProduct(prodID);
                }
                catch(Exception ex)
                {
                    Console.Write(ex.Message);
                }
                finally
                {
                    if (!product.Equals(emptyProduct))
                    {
                        prodDetails.InnerHtml = "<div class='col-lg-9'>" +
                                                    "<div class='thumbnail'>" +
                                                            "<img class='img-responsive' src='" + product.picture + "' alt=''/>" +
                                                            "<div class='caption-full' >" +
                                                                "<h3 class='pull-right' id='Price' style='color: #B20000;'>R" + (Math.Round(product.price, 2)).ToString("#.00", CultureInfo.InvariantCulture) + "</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Name: </span>" + product.name + "</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Type: </span>" + product.type + "</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Weight: </span>" + product.weight + "g</h3>" +
                                                                "<h3><span style='color: #67BCDB;font-family: inlineHeading;'>Description: </span>" + product.description + "</h3>" +
                                                            "</div>" +
                                                        "<br/>" +
                                                        "<a class='btn btn-success' id ='Buy'>Add to Cart</a>" +
                                                    "</div>" +
                                                "</div>";
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