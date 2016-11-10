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
        public int size;

        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseService.DBServiceClient data = new DatabaseService.DBServiceClient();

            if (Session["AllUserDetails"] != null) { 
            DatabaseService.User userdata = (DatabaseService.User)Session["AllUserDetails"];
                if (data.CheckForCart(userdata.userID))
                {
                    List<DatabaseService.Cart> ListCart = new List<DatabaseService.Cart>();
                    DatabaseService.Cart[] tempCart = data.GetCart(userdata.userID);
                    foreach (DatabaseService.Cart tempItem in tempCart)
                    {
                        ListCart.Add(tempItem);
                    }
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

                        System.Web.UI.HtmlControls.HtmlGenericControl createDiv =  new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        createDiv.ID = "createDiv" +i;
                        createDiv.InnerHtml = "< input class='Quantity" + i + "' type='number' min='0'  value='" + ListCart[i].quantity + "' name='NoItems' /> ";
                        Quantity.Controls.Add(createDiv);

                        Price.Text = Math.Round(productget.price,2).ToString("#.00", CultureInfo.InvariantCulture);
                        cost[i] = double.Parse(Price.Text);


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
                            if (chck[i].Checked)
                            {
                                total += cost[i];
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