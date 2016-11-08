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
        private const String TABLE_ROW_START = "<tr>";
        private const String TABLE_ROW_END = "</tr>";

        private List<int> NUMBER_REF = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

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
        }

        private int returnPos()
        {
            return 0;
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
                //localhost.Product[] tempProducts = myService.GetProductByString(SearchQuery);
                List<localhost.Product> searchedProducts = new List<localhost.Product>();

                localhost.Product temp = new localhost.Product();
                temp.productID = 1;
                temp.name = "Test Name1";
                temp.type = "Sugar Dammit";
                temp.weight = 500;
                temp.description = "This is just a temp description to see formatting";
                temp.picture = "../Images/Food/noimage.jpg";
                temp.price = 12.32;
                searchedProducts.Add(temp);
                temp = null;

                temp = new localhost.Product();
                temp.productID = 2;
                temp.name = "Test Name2";
                temp.type = "Sugar Dammit";
                temp.weight = 500;
                temp.description = "This is just a temp description to see formatting";
                temp.picture = "../Images/Food/noimage.jpg";
                temp.price = 12.32;
                searchedProducts.Add(temp);
                temp = null;

                temp = new localhost.Product();
                temp.productID = 3;
                temp.name = "Test Name3";
                temp.type = "Sugar Dammit";
                temp.weight = 500;
                temp.description = "This is just a temp description to see formatting";
                temp.picture = "../Images/Food/noimage.jpg";
                temp.price = 12.32;
                searchedProducts.Add(temp);
                temp = null;

                temp = new localhost.Product();
                temp.productID = 4;
                temp.name = "Test Name4";
                temp.type = "Sugar Dammit";
                temp.weight = 500;
                temp.description = "This is just a temp description to see formatting";
                temp.picture = "../Images/Food/noimage.jpg";
                temp.price = 12.32;
                searchedProducts.Add(temp);
                temp = null;

                temp = new localhost.Product();
                temp.productID = 5;
                temp.name = "Test Name5";
                temp.type = "Sugar Dammit";
                temp.weight = 500;
                temp.description = "This is just a temp description to see formatting";
                temp.picture = "../Images/Food/noimage.jpg";
                temp.price = 12.32;
                searchedProducts.Add(temp);
                temp = null;

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

        private void returnSearch(List<localhost.Product> searchedProducts)
        {
            int numProd = searchedProducts.Count;
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
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;

                }
            }

        }
    }
}
