using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm3 : System.Web.UI.Page
    {//DataExplorer://localhost(FoodCrateDB)/Table/``.`foodcratedb`.`products`
        private const String TABLE_START = "<table>";
        private const String TABLE_END = "</table>";
        public struct Product
        {
            public long productID;
            public string name;
            public string type;
            public int weight;
            public string description;
            public string picture;
            public double price;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            cardTable.InnerHtml = "<table><tr><td>THIS IS HERE</td></tr></table>";
        }

        protected void searchDB (object sender, EventArgs e)
        {
            String cardDisplay = "";
            cardTable.InnerHtml = "";
            localhost.Service1 myService = new localhost.Service1();

            String InvalidQuery = "Search our Catalogue by the Name or Type of Product";
            String SearchQuery = txtSearch.Value;

            if (!SearchQuery.Equals(InvalidQuery))
            {
                localhost.Product[] tempProducts = myService.GetProductByString(SearchQuery);
                List<localhost.Product> searchedProducts = new List<localhost.Product>(tempProducts);

                cardDisplay = TABLE_START;
               
                int trackProd = 0;
                int numProd = searchedProducts.Count;
                if (numProd == 0)
                {
                    cardDisplay = "<h2 style='text-align: center;'>No items matching your search where found</h2>";
                }
                else
                {
                    for (int i = 0; i <= numProd / 3; i++)
                    {
                        if (numProd % 3 == 1)
                        {
                            cardDisplay += "<tr>" +
                                                    "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[trackProd].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[trackProd].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[trackProd].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID="+ searchedProducts[trackProd].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                            trackProd++;
                            cardDisplay += "</tr>";

                        }
                        else if (numProd % 3 == 2)
                        {
                            cardDisplay += "<tr>" +
                                                    "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[trackProd].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[trackProd].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[trackProd].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[trackProd].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                            trackProd++;
                            cardDisplay += "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[trackProd].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[trackProd].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[trackProd].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[trackProd].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                            trackProd++;
                            cardDisplay += "</tr>";
                        }
                        else if (numProd % 3 == 0 && numProd != 0)
                        {
                            cardDisplay += "<tr>" +
                                                   "<td>" +
                                                       "<div id ='cardDisplay' class='cardDisplay'>" +
                                                           "<div class='card'>" +
                                                               "<div class='card_top'>" +
                                                                   "<img src =" + searchedProducts[trackProd].picture + " />" +
                                                               "</div>" +
                                                               "<div class='card_bottom'>" +
                                                                   "<h2>" + searchedProducts[trackProd].name + "</h2>" +
                                                                   "<div class='card_bottom__description'>" +
                                                                       "<p>" +
                                                                           searchedProducts[trackProd].description +
                                                                       "</p>" +
                                                                       "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[trackProd].productID + "' target='_blank'>Read more</a>" +
                                                                   "</div>" +
                                                               "</div>" +
                                                           "</div>" +
                                                       "</div>" +
                                                   "</td>";
                            trackProd++;
                            cardDisplay += "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[trackProd].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[trackProd].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[trackProd].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[trackProd].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                            trackProd++;
                            cardDisplay += "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[trackProd].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[trackProd].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[trackProd].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[trackProd].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                            trackProd++;
                            cardDisplay += "</tr>";
                        }
                    }
                }
                cardDisplay += TABLE_END;
                cardTable.InnerHtml = cardDisplay;
            }
        }
    }
}