using FoodCrate_V1._01.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public TextBox[] tb;
        public int size;
        private List<DatabaseService.Cart> ListCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();

            if (Session["AllUserDetails"] != null) { 
            DatabaseService.User userdata = (DatabaseService.User)Session["AllUserDetails"];
                if (data.CheckForCart(userdata.userID))
                {
                    ListCart = new List<DatabaseService.Cart>();
                    DatabaseService.Cart[] tempCart = data.GetCart(userdata.userID);
                    foreach (DatabaseService.Cart tempItem in tempCart)
                    {
                        ListCart.Add(tempItem);
                    }
                    chck = new CheckBox[ListCart.Count];
                    cost = new double[ListCart.Count];
                    tb = new TextBox[ListCart.Count];
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

                        tb[i] = new TextBox();
                        tb[i].ID = string.Format("txt{0}", i);
                        tb[i].Text = "1";
                        Quantity.Controls.Add(tb[i]);

                        Price.Text = Math.Round(productget.price,2).ToString("#.00", CultureInfo.InvariantCulture);
                        cost[i] = double.Parse(Price.Text, System.Globalization.CultureInfo.InvariantCulture);


                        chck[i] = new CheckBox();
                        chck[i].ID = string.Format("chk{0}", i);
                        remove.Controls.Add(chck[i]);


                        row.Cells.Add(NameOfItem);
                        row.Cells.Add(Quantity);
                        row.Cells.Add(Price);
                        row.Cells.Add(remove);
                        table.Rows.Add(row);
                    }
                    TableRow rowend = new TableRow();
                    TableCell Blank = new TableCell();
                    TableCell Total = new TableCell();
                    TableCell payment = new TableCell();
                    Total.Text = "Total: ";

                    double total = 0;


                    if (Session["AllUserDetails"] != null)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (!chck[i].Checked)
                            {   
                                total += cost[i] * int.Parse(tb[i].Text);
                            }
                        }
                    }
                    payment.Text = total.ToString();


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
            double total = 0;


            if (Session["AllUserDetails"] != null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (!chck[i].Checked)
                    {
                        total+= cost[i] * int.Parse(tb[i].Text);
                    }
                }
             }

            Session["cartList"] = ListCart;
            Response.Redirect("../Pages/SCartReview.aspx?Total=" + total);
        }
    }
}