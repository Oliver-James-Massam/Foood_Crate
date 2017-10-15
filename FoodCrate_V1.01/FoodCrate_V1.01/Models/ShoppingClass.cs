using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodCrate_V1._01.Models
{
    public class ShoppingClass
    {
        private string[] productID;
        private int[] quantity;

        public ShoppingClass()
        {
            productID = new string[1];
            quantity = new int[1];
         }

        public void Additem(string ID, int no)
        {
            string[] newProduct;
            int[] newQuantity;
            int Newlenght;
            int post = -3;
            Boolean exists = false;
            Newlenght = productID.Length;

            // creating new structure
             for (int i = 0; i < Newlenght; i++)
            {
                if (productID[i] == ID)
                {
                    exists = true;
                    post = i;
                }
            }
                    
            // find if item exists
            if (exists)
            {
                quantity[post] += no; 
            }
            else // doesnt exist so we add it
            {
                newProduct = new string[productID.Length + 1] ;
                for (int i =0; i < productID.Length; i++)
                {
                    newProduct[i] = productID[i];
                }
                newProduct[newProduct.Length] = ID;


                newQuantity = new int[quantity.Length + 1];
                for (int i = 0; i < quantity.Length; i++)
                {
                    newQuantity[i] = quantity[i];
                }
                newProduct[newQuantity.Length] = ID;

                // set new quantity
                setnewQuant(newProduct, newQuantity);
            }
        }

        private void setnewQuant(string[] artID,int[] artno)
        {
            productID = artID;
            quantity = artno;
        }

    }
}