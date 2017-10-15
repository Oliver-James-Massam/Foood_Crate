using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DatabaseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface DBService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string TestConnection();

        [OperationContract]
        SqlDataReader ExecuteQuery(string sqlQuery);

        [OperationContract]
        bool ExecuteNonQuery(string sqlQuery);

        //requested data processing functions
            
        [OperationContract]
        long TotalSales();

        [OperationContract]
        long TotalRegisteredUsers();

        [OperationContract]
        double CashGenerated(DateTime fromHere, DateTime toHere);

        [OperationContract]
        long TotalProductsSold();

        [OperationContract]
        int AuthUser(string email, string password);

        [OperationContract]
        bool UniqueUsername(string username);

        [OperationContract]
        long CountProducts();

        //add data functions

        [OperationContract]
        long AddUser(string username, string name, string surname, string email, int type, string password);

        [OperationContract]
        long AddProduct(string name, string type, int weight, string description, string picture, double price);

        [OperationContract]
        long AddRecipe(string name, long creator, string shortdesc, string fulldesc, string picture);

        [OperationContract]
        long AddIngredient(long recipeID, long productID, int quantity);

        [OperationContract]
        long AddInvoice(long UserID);

        [OperationContract]
        long AddInvoiceItem(long invoiceID, long productID, int quantity, int discount, double total);

        //update data functions

        [OperationContract]
        bool SetUserName(long userID, string name);

        [OperationContract]
        bool SetUserSurname(long userID, string surname);

        [OperationContract]
        bool SetUserUsername(long userID, string username);

        //get data functions

        [OperationContract]
        User GetUser(string email, string password);

        [OperationContract]
        User GetUserByEmail(string email);

        [OperationContract]
        Product GetProduct(long productID);

        [OperationContract]
        Recipe GetRecipe(long recipeID);

        [OperationContract]
        Ingredient GetIngredient(long ingredientID);

        [OperationContract]
        Invoice GetInvoice(long invoiceID);

        [OperationContract]
        InvoiceItem GetInvoiceItem(long invoiceItemID);

        [OperationContract]
        List<Invoice> GetInvoicesByUser(long userID);

        //Cart Functions

        [OperationContract]
        long AddCart(long userID, long productID, int quantity);

        [OperationContract]
        bool CheckForCart(long userID);

        [OperationContract]
        bool RemoveCartItem(long cartID);

        [OperationContract]
        List<Cart> GetCart(long userID);

        //Delete Data Functions

        [OperationContract]
        bool RemoveProduct(long productID);

        //Added new function for Search parameters
        [OperationContract]
        List<Product> GetProductByString(String NameOrType);
    }

    public struct Cart
    {
        public long cartID;
        public long userID;
        public long productID;
        public int quantity;
    }

    [DataContract]
    [KnownType(typeof(InvoiceItem[]))]
    public struct Invoice
    {
        [DataMember]
        public long invoiceID;
        [DataMember]
        public long userID;
        [DataMember]
        public DateTime creationDate;
        [DataMember]
        public DateTime dueDate;
        [DataMember]
        public DateTime fullyPaidDate;
        [DataMember]
        public string status;
        [DataMember]
        public List<InvoiceItem> invoiceItems;
    }

    [DataContract]
    public struct InvoiceItem
    {
        [DataMember]
        public long invoiceID;
        [DataMember]
        public long productID;
        [DataMember]
        public int quantity;
        [DataMember]
        public int discount;
        [DataMember]
        public double total;
    }

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

    public struct User
    {
        public long userID;
        public string userName;
        public string name;
        public string surname;
        public string email;
        public long type;
        public string password;
    }

    public struct UserType
    {
        public long userTypeID;
        public string name;
    }

    public struct Recipe
    {
        public long recipeID;
        public string name;
        public long creator;
        public string shortDesc;
        public string fullDesc;
        public string picture;
        public List<Ingredient> ingredients;
    }

    public struct Ingredient
    {
        public long recipeID;
        public long productID;
        public int quantity;
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
