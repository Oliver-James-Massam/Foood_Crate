using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm3 : System.Web.UI.Page
    {
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String InvalidQuery = "Search our Catalogue by the Name or Type of Product";
            String SearchQuery = txtSearch.Value;

            if(!SearchQuery.Equals(InvalidQuery))
            {

            }

        }
    }
}