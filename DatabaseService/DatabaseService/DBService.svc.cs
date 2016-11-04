﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
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

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`Users` (`UserName`, `Name`, `Surname`, `Email`, `Type`, `Password`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, username, name, surname, email, type, password));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddInvoice(long userID)
        {
            long result = -1;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "INSERT INTO foodcratedb.invoices(UserID,CreationDate,DueDate,Status) VALUES ('{0}', '{1}', '{2}', 'Pending')";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, userID, DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Today.AddMonths(INVOICE_DUEDATE_MONTH_MODIFIER).ToString("yyyy-MM-dd")));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddInvoiceItem(long invoiceID, long productID, int quantity, int discount, double total)
        {
            long result = -1;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "INSERT INTO foodcratedb.invoiceitems(InvoiceID,ProductID,Quantity,Discount,Total) VALUES ('{0}', '{1}', '{2}', '{3}','{4}');";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, invoiceID, productID, quantity, discount, total));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddProduct(string name, string type, int weight, string description, string picture, double price)
        {
            long result = -1;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`products` (`Name`, `Type`, `Weight`, `Description`, `Picture`, `Price`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, name, type, weight, description, picture, price));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddRecipe(string name, long creator, string shortdesc, string fulldesc, string picture)
        {
            long result = -1;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`recipes` (`Name`, `Creator`, `ShortDesc`, `FullDesc`, `Picture`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, name, creator, shortdesc, fulldesc, picture));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long AddIngredient(long recipeID, long productID, int quantity)
        {
            long result = -1;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "INSERT INTO `foodcratedb`.`ingredients` (`RecipeID`, `ProductID`, `Quantity`) VALUES ('{0}', '{1}', '{2}');";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, recipeID, productID, quantity));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public int AuthUser(string email, string password)
        {
            int result = 0;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.users;";
            MySqlCommand cmd = new MySqlCommand(string.Format(query));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetString("email").Equals(email, StringComparison.Ordinal) && reader.GetString("password").Equals(password, StringComparison.Ordinal))
                    {
                        result = reader.GetInt16("type");
                        goto postLoop;
                    }
                }
                result = 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
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

            MySqlConnection cn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(ProductID) FROM foodcratedb.products");
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                reader.Read();
                result = reader.GetInt64(0);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;

        }

        public bool ExecuteNonQuery(string sqlQuery)
        {
            bool result = false;

            MySqlConnection cn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public MySqlDataReader ExecuteQuery(string sqlQuery)
        {
            MySqlDataReader result = null;

            MySqlConnection cn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                result = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public bool UniqueUsername(string username)
        {
            bool result = true;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.users WHERE username = '" + username + "';";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public User GetUser(long userID)
        {
            User result = new User();

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.users WHERE userID = '" + userID + "';";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
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
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public Product GetProduct(long productID)
        {
            Product result = new Product();

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.products WHERE productID = '" + productID + "';";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
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
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
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

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.recipes WHERE recipeID = '" + recipeID + "';";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query,cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
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
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
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
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
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

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM foodcratedb.invoices WHERE invoiceID = '" + invoiceID + "';";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
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
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();
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
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
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

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT COUNT(InvoiceID) FROM foodcratedb.invoices;";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt64(0);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long TotalRegisteredUsers()
        {
            long result = 0;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT COUNT(UserID) FROM foodcratedb.users;";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt64(0);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public double CashGenerated(DateTime fromHere, DateTime toHere)
        {
            double result = 0;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT SUM(b.Total) FROM foodcratedb.invoices a,foodcratedb.invoiceitems b WHERE a.InvoiceID = b.InvoiceID AND a.FullyPaidDate BETWEEN '{0}' AND '{1}';";
            MySqlCommand cmd = new MySqlCommand(string.Format(query, fromHere.ToString("yyyy-MM-dd"), toHere.ToString("yyyy-MM-dd")));
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                    {
                        result = reader.GetDouble(0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            cmd.Connection.Close();
            cmd.Dispose();
            cn.Dispose();
            return result;
        }

        public long TotalProductsSold()
        {
            long result = 0;

            MySqlConnection cn = new MySqlConnection(connectionString);
            string query = "SELECT SUM(quantity) FROM foodcratedb.invoiceitems;";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt64(0);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
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
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                return "Connection open";
            }
        }
    }
}