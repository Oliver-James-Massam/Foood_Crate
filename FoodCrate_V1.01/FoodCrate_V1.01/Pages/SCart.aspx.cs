using FoodCrate_V1._01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodCrate_V1._01.MasterPage
{
    public partial class WebForm10 : System.Web.UI.Page
    {

        public CheckBox[] chck;
        public double[] cost;
        public int size;

        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
            if (Session["AllUserDetails"] != null) { 
            DatabaseService.User userdata = (DatabaseService.User)Session["AllUserDetails"];
                if (data.CheckForCart(userdata.userID))
                {
                    DatabaseService.Cart[] ListCartarryy =  data.GetCart(userdata.userID);
                    int size = ListCartarryy.Length;
                    List<DatabaseService.Cart> ListCart = new List<DatabaseService.Cart>((DatabaseService.Cart[])ListCartarryy);
                    chck = new CheckBox[ListCart.Count];
                    cost = new double[ListCart.Count];
                    size = ListCart.Count;
                    for (int i =0; i < ListCart.Count; i++)
                    {
                        TableRow row = new TableRow();
                        TableCell NameOfItem = new TableCell();
                        TableCell Quantity = new TableCell();
                        TableCell Price = new TableCell();
                        TableCell remove = new TableCell();
                        DatabaseService.Product productget = data.GetProduct(ListCart[i].productID);

                        NameOfItem.Text = productget.name;



                        Quantity.Text = "< input class='Quantity" + i + "' type='number' min='0'  value='" + ListCart[i].quantity +  "' name='NoItems' />";


                        Price.Text =productget.price.ToString();
                        cost[i] = productget.price;


                        chck[i] = new CheckBox();
                        chck[i].ID = string.Format("chk{0}", i);
                        chck[i].Text = chck + Convert.ToString(i);
                        remove.Controls.Add(chck[i]);


                        row.Cells.Add(NameOfItem);
                        row.Cells.Add(Quantity);
                        row.Cells.Add(Price);
                        row.Cells.Add(remove);
                        table.Rows.Add(row);
                    }
                }
                
        }
            else
            {
                Response.Redirect("../Pages/Login.aspx");
            }

        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();
            List<DatabaseService.Cart> ListCart = new List<DatabaseService.Cart>();
            double total = 0;


            if (Session["AllUserDetails"] != null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (chck[i].Checked)
                    {
                        total+= cost[i];
                    }
                }
             }

            Session["cartList"] = ListCart;
            Response.Redirect("../Pages/SCartReview.aspx?Total=" + total);
        }
    }
}