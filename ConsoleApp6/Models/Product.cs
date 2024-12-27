using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Product
    {
        public void GetInfo(string name)
        {
            Console.WriteLine($"Product Name: {name}");
        }
        public void GetInfo(string name, int price)
        {
            Console.WriteLine($"Product Name: {name}, Price: {price}");
        }
        public void GetInfo(string name, int price, int qty)
        {
            int total = qty * price;
            Console.WriteLine($"Product Name: {name}, Price: {price} , Qty: {qty} , Total: {CalcTotal(price, qty)}");
        }

        public int CalcTotal(int price, int qty)
        {
            return price * qty;
        }

        // Add List of Products
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public bool InStock { get; set; }

        // declare list of product
        List<Product> productsList = new List<Product>();


        public void AddProduct(string name, int price, int qty, bool inStock)
        {
            productsList.Add(new Product { Name = name, Price = price, Qty = qty , InStock = inStock});
        }

        public void DisplayProducts()
        {
            int countIn = 0;
            //int countOut = 0;
            Console.WriteLine("----- All Products -----");
            foreach (Product item in productsList)
            {
                if (item.InStock == true)
                {
                    countIn++;
                    Console.WriteLine("Name: " + item.Name + "    " + "Price: " + item.Price + "Kd    " +
                   "Qty: " + item.Qty + "  " + " Total: " + CalcTotal(item.Price, item.Qty)+ "availability: Item is in stock");
                }
                else
                {
                    //countOut++;
                    Console.WriteLine("Name: " + item.Name + "    " + "Price: " + item.Price + "Kd    " +
                   "Qty: " + item.Qty + "  " + " Total: " + CalcTotal(item.Price, item.Qty)+ "availability: Item is out of stock");
                }
            }

            Console.WriteLine("Total Items :  "+productsList.Count+" and in stock" + countIn + "out of stock" + (productsList.Count - countIn));

            // Iphone 500 6 (3000Kd) InStock
            // samsung 500 6 (3000Kd) InStock

            // Total Items : 5 ,  (2) in stock  , (3) out of stock
        }


    }
}
