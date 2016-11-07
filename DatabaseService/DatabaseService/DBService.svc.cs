using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : DataCsharp
    {
        private static readonly string connectionString = @"server=localhost;user id=admin;Password=Foodcrate1;persistsecurityinfo=True;database=foodcratedb";
        public static readonly int INVOICE_DUEDATE_MONTH_MODIFIER = 1;

        public long AddUser(string username, string name, string surname, string email, int type, string password)
        {
            long result = -1;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`Users` (`UserName`, `Name`, `Surname`, `Email`, `Type`, `Password`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";
            SqlCommand cmd = new SqlCommand(string.Format(query, username, name, surname, email, type, password));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddInvoice(long userID)
        {
            long result = -1;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "INSERT INTO foodcratedb.invoices(UserID,CreationDate,DueDate,Status) VALUES ('{0}', '{1}', '{2}', 'Pending')";
            SqlCommand cmd = new SqlCommand(string.Format(query, userID, DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Today.AddMonths(INVOICE_DUEDATE_MONTH_MODIFIER).ToString("yyyy-MM-dd")));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddInvoiceItem(long invoiceID, long productID, int quantity, int discount, double total)
        {
            long result = -1;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "INSERT INTO foodcratedb.invoiceitems(InvoiceID,ProductID,Quantity,Discount,Total) VALUES ('{0}', '{1}', '{2}', '{3}','{4}');";
            SqlCommand cmd = new SqlCommand(string.Format(query, invoiceID, productID, quantity, discount, total));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddProduct(string name, string type, int weight, string description, string picture, double price)
        {
            long result = -1;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`products` (`Name`, `Type`, `Weight`, `Description`, `Picture`, `Price`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";
            SqlCommand cmd = new SqlCommand(string.Format(query, name, type, weight, description, picture, price));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddRecipe(string name, long creator, string shortdesc, string fulldesc, string picture)
        {
            long result = -1;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`recipes` (`Name`, `Creator`, `ShortDesc`, `FullDesc`, `Picture`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');";
            SqlCommand cmd = new SqlCommand(string.Format(query, name, creator, shortdesc, fulldesc, picture));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddIngredient(long recipeID, long productID, int quantity)
        {
            long result = -1;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`ingredients` (`RecipeID`, `ProductID`, `Quantity`) VALUES ('{0}', '{1}', '{2}');";
            SqlCommand cmd = new SqlCommand(string.Format(query, recipeID, productID, quantity));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public int AuthUser(string email, string password)
        {
            int result = 0;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.users;";
            SqlCommand cmd = new SqlCommand(string.Format(query));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    if ((reader["email"].Equals(email)) && (reader["password"].Equals(password)))
                    {
                        result = (int) reader["type"];
                        goto postLoop;
                    }
                }
                result = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            postLoop:
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long CountProducts()
        {
            long result = 0;

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(ProductID) FROM foodcratedb.products");
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                reader.Read();
                result = reader.GetInt64(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;

        }

        public bool ExecuteNonQuery(string sqlQuery)
        {
            bool result = false;

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            SqlDataReader result = null;

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public bool UniqueUsername(string username)
        {
            bool result = true;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.users WHERE username = '" + username + "';";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public User GetUser(long userID)
        {
            User result = new User();

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.users WHERE userID = '" + userID + "';";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result.userID = reader.GetInt64(0);
                    result.userName = reader.GetString(1);
                    result.name = reader.GetString(2);
                    result.surname = reader.GetString(3);
                    result.email = reader.GetString(4);
                    result.type = reader.GetInt64(5);
                    result.password = reader.GetString(6);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public Product GetProduct(long productID)
        {
            Product result = new Product();

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.products WHERE productID = '" + productID + "';";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result.productID = reader.GetInt64(0);
                    result.name = reader.GetString(1);
                    result.type = reader.GetString(2);
                    result.weight = reader.GetInt32(3);
                    result.description = reader.GetString(4);
                    result.picture = reader.GetString(5);
                    result.price = reader.GetDouble(6);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public Recipe GetRecipe(long recipeID)
        {
            Recipe result = new Recipe();
            result.ingredients = new List<Ingredient>();

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.recipes WHERE recipeID = '" + recipeID + "';";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query,cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        result.recipeID = reader.GetInt64(0);
                        result.name = reader.GetString(1);
                        result.creator = reader.GetInt64(2);
                        result.shortDesc = reader.GetString(3);
                        result.fullDesc = reader.GetString(4);
                        result.picture = reader.GetString(5);
                    }
                }

                query = "SELECT * FROM foodcratedb.ingredients WHERE ingredientID = '" + result.recipeID + "';";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.HasRows)
                    {
                        Ingredient i = new Ingredient();
                        reader.Read();
                        i.recipeID = reader.GetInt64(0);
                        i.productID = reader.GetInt64(1);
                        i.quantity = reader.GetInt32(2);
                        result.ingredients.Add(i);
                    }
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            return result;
        }

        public Ingredient GetIngredient(long ingredientID)
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoice(long invoiceID)
        {
            Invoice result = new Invoice();
            result.invoiceItems = new List<InvoiceItem>();

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.invoices WHERE invoiceID = '" + invoiceID + "';";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        result.invoiceID = reader.GetInt64(0);
                        result.userID = reader.GetInt64(1);
                        result.creationDate = reader.GetDateTime(2);
                        result.dueDate = reader.GetDateTime(3);
                        if(!reader.IsDBNull(4))
                        {
                            result.fullyPaidDate = reader.GetDateTime(4);
                        }
                        result.status = reader.GetString(5);
                    }
                }

                query = "SELECT * FROM foodcratedb.invoiceitems WHERE invoiceID = '" + result.invoiceID + "';";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.HasRows)
                    {
                        InvoiceItem i = new InvoiceItem();
                        reader.Read();
                        i.invoiceID = reader.GetInt64(0);
                        i.productID = reader.GetInt64(1);
                        i.quantity = reader.GetInt32(2);
                        i.discount = reader.GetInt32(3);
                        i.total = reader.GetDouble(4);
                        result.invoiceItems.Add(i);
                    }
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            return result;
        }

        public InvoiceItem GetInvoiceItem(long invoiceItemID)
        {
            throw new NotImplementedException();
        }

        public long TotalSales()
        {
            long result = 0;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT COUNT(InvoiceID) FROM foodcratedb.invoices;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt64(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long TotalRegisteredUsers()
        {
            long result = 0;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT COUNT(UserID) FROM foodcratedb.users;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt64(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public double CashGenerated(DateTime fromHere, DateTime toHere)
        {
            double result = 0;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT SUM(b.Total) FROM foodcratedb.invoices a,foodcratedb.invoiceitems b WHERE a.InvoiceID = b.InvoiceID AND a.FullyPaidDate BETWEEN '{0}' AND '{1}';";
            SqlCommand cmd = new SqlCommand(string.Format(query, fromHere.ToString("yyyy-MM-dd"), toHere.ToString("yyyy-MM-dd")));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                    {
                        result = reader.GetDouble(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long TotalProductsSold()
        {
            long result = 0;

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT SUM(quantity) FROM foodcratedb.invoiceitems;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt64(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string TestConnection()
        {

            string connectionString = @"server=localhost;user id=admin;Password=Foodcrate1;persistsecurityinfo=True;database=foodcratedb";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                return "Connection open";
            }
        }

        //Added new Function for Search parameters
        public List<Product> GetProductByString(string NameOrType)
        {
            Product result = new Product();
            List<Product> allProducts = new List<Product>();

            SqlConnection cn = new SqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.products WHERE name LIKE '%" + NameOrType + "%' OR type LIKE '%" + NameOrType + "%';";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    result.productID = reader.GetInt64(0);
                    result.name = reader.GetString(1);
                    result.type = reader.GetString(2);
                    result.weight = reader.GetInt32(3);
                    result.description = reader.GetString(4);
                    result.picture = reader.GetString(5);
                    result.price = reader.GetDouble(6);
                    allProducts.Add(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex  + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return allProducts;
        }

        MySqlDataReader DataCsharp.ExecuteQuery(string sqlQuery)
        {
            throw new NotImplementedException();
        }
    }
}
