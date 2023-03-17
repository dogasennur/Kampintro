// See https://aka.ms/new-console-template for more information

using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CatogoryId=2;
product1.ProductName = "masa";
product1.UnitPrice = 500;
product1.UnitsİnStock= 3;


// {} işaretine dikkat 
Product product2 = new Product { Id = 2, CatogoryId = 5, UnitsİnStock = 5, 
    ProductName = "kalem", UnitPrice = 35 };


//  PascalCase   //camelCase

ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);



