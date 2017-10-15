﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private const String TABLE_START = "<table>";
        private const String TABLE_END = "</table>";
        private const String TABLE_ROW_START = "<tr>";
        private const String TABLE_ROW_END = "</tr>";

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie MyCookie = new HttpCookie("cart");
            if (Session["user"] != null)
            {
                greeting.InnerHtml = "Welcome " + Session["user"];
            }
        }

        protected void searchDB (object sender, EventArgs e)
        {
            cardTable.InnerHtml = "";
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();

            String InvalidQuery = "Search our Catalogue by the Name or Type of Product";
            String SearchQuery = txtSearch.Value;

            if (!SearchQuery.Equals(InvalidQuery))
            {
                List<DatabaseService.Product> searchedProducts = new List<DatabaseService.Product>();
                DatabaseService.Product[] tempProducts = data.GetProductByString(SearchQuery);
                foreach(DatabaseService.Product tempProduct in tempProducts)
                {
                    searchedProducts.Add(tempProduct);
                }

                int numProd = searchedProducts.Count;
                if (numProd == 0)
                {
                    cardTable.InnerHtml = "<h2 style='text-align: center;'>No items matching your search where found</h2>";
                }
                else
                {
                    returnSearch(searchedProducts);
                }
            }
        }

        private void returnSearch(List<DatabaseService.Product> searchedProducts)
        {
            int numProd = searchedProducts.Count;
            String maxSearched = "";
            if (numProd > 12)
            {
                maxSearched = "<br/><br/><h2>Max of 12 Items per Search</h2>";
            }
            for (int i = 0; i < numProd; i++)
            {
                switch (i)
                {
                    case 0://1
                        cardTable.InnerHtml += TABLE_START + TABLE_ROW_START +
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[0].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[0].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[0].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[0].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                        if (0 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 1://2
                        cardTable.InnerHtml +=
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[1].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[1].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[1].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[1].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                        if (1 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 2://3
                        cardTable.InnerHtml +=
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[2].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[2].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[2].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[2].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>" +
                                                    TABLE_ROW_END;
                        if (2 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_END;
                        break;
                    case 3://4
                        cardTable.InnerHtml += TABLE_ROW_START +
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[3].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[3].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[3].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[3].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                        if (3 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 4://5
                        cardTable.InnerHtml +=
                                               "<td>" +
                                                       "<div id ='cardDisplay' class='cardDisplay'>" +
                                                           "<div class='card'>" +
                                                               "<div class='card_top'>" +
                                                                   "<img src =" + searchedProducts[4].picture + " />" +
                                                               "</div>" +
                                                               "<div class='card_bottom'>" +
                                                                   "<h2>" + searchedProducts[4].name + "</h2>" +
                                                                   "<div class='card_bottom__description'>" +
                                                                       "<p>" +
                                                                           searchedProducts[4].description +
                                                                       "</p>" +
                                                                       "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[4].productID + "' target='_blank'>Read more</a>" +
                                                                   "</div>" +
                                                               "</div>" +
                                                           "</div>" +
                                                       "</div>" +
                                                   "</td>";
                        if (4 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 5://6
                        cardTable.InnerHtml +=
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[5].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[5].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[5].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[5].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>" +
                                                    TABLE_ROW_END;
                        if (5 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_END;
                        break;
                    case 6://7
                        cardTable.InnerHtml += TABLE_ROW_START +
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[6].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[6].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[6].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[6].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                        if (6 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 7://8
                        cardTable.InnerHtml +=
                                               "<td>" +
                                                       "<div id ='cardDisplay' class='cardDisplay'>" +
                                                           "<div class='card'>" +
                                                               "<div class='card_top'>" +
                                                                   "<img src =" + searchedProducts[7].picture + " />" +
                                                               "</div>" +
                                                               "<div class='card_bottom'>" +
                                                                   "<h2>" + searchedProducts[7].name + "</h2>" +
                                                                   "<div class='card_bottom__description'>" +
                                                                       "<p>" +
                                                                           searchedProducts[7].description +
                                                                       "</p>" +
                                                                       "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[7].productID + "' target='_blank'>Read more</a>" +
                                                                   "</div>" +
                                                               "</div>" +
                                                           "</div>" +
                                                       "</div>" +
                                                   "</td>";
                        if (8 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 8://9
                        cardTable.InnerHtml +=
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[8].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[8].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[8].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[8].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>" +
                                                    TABLE_ROW_END;
                        if (8 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_END;
                        break;
                    case 9://10
                        cardTable.InnerHtml += TABLE_ROW_START +
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[9].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[9].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[9].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[9].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>";
                        if (9 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 10://11
                        cardTable.InnerHtml +=
                                               "<td>" +
                                                       "<div id ='cardDisplay' class='cardDisplay'>" +
                                                           "<div class='card'>" +
                                                               "<div class='card_top'>" +
                                                                   "<img src =" + searchedProducts[10].picture + " />" +
                                                               "</div>" +
                                                               "<div class='card_bottom'>" +
                                                                   "<h2>" + searchedProducts[10].name + "</h2>" +
                                                                   "<div class='card_bottom__description'>" +
                                                                       "<p>" +
                                                                           searchedProducts[10].description +
                                                                       "</p>" +
                                                                       "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[10].productID + "' target='_blank'>Read more</a>" +
                                                                   "</div>" +
                                                               "</div>" +
                                                           "</div>" +
                                                       "</div>" +
                                                   "</td>";
                        if (10 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_ROW_END + TABLE_END;
                        break;
                    case 11://12
                        cardTable.InnerHtml +=
                                                "<td>" +
                                                        "<div id ='cardDisplay' class='cardDisplay'>" +
                                                            "<div class='card'>" +
                                                                "<div class='card_top'>" +
                                                                    "<img src =" + searchedProducts[11].picture + " />" +
                                                                "</div>" +
                                                                "<div class='card_bottom'>" +
                                                                    "<h2>" + searchedProducts[11].name + "</h2>" +
                                                                    "<div class='card_bottom__description'>" +
                                                                        "<p>" +
                                                                            searchedProducts[11].description +
                                                                        "</p>" +
                                                                        "<a href = '../Pages/ProductDetails.aspx?productID=" + searchedProducts[11].productID + "' target='_blank'>Read more</a>" +
                                                                    "</div>" +
                                                                "</div>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</td>" +
                                                   TABLE_ROW_END;
                        if (numProd > 12)
                            cardTable.InnerHtml += TABLE_ROW_START + "<td></td>" + "<td>" + maxSearched + "</td>" + TABLE_ROW_END + TABLE_END;
                        else if (11 == (numProd - 1))
                            cardTable.InnerHtml += TABLE_END;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
