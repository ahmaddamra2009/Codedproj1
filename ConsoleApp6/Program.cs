

using ConsoleApp6.Models;
#region DeclareCode
Product product = new Product();

string name;
int price, qty;
#endregion
//Objec class

// Input
Console.Write("Enter Product Name");
name =Console.ReadLine();
Console.Write("Enter Product Price");
price = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Product Qty");
qty = Convert.ToInt32(Console.ReadLine());


// Use Functions
// Print Name
product.GetInfo(name);
// Print Name & Price
product.GetInfo(name, price);
// Print Name & Price & Qty
product.GetInfo(name, price,qty);


//product.AddProduct(product.Name, product.Price ,product.Qty,true);

//product.GetInfo();
Console.WriteLine("Number of products");
int count =Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=count; i++) {

    Console.Write("Enter Product Name: ");
    string ProductName= Console.ReadLine();

    Console.Write("Enter Product price");
    int Price = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter Qty");
    int Qty =Convert.ToInt32(  Console.ReadLine());

    Console.WriteLine("Enter availability: ");
    bool inStock = Convert.ToBoolean(Console.ReadLine());

    product.AddProduct(ProductName, Price, Qty,inStock);
}
product.DisplayProducts();

