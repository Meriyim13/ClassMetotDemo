using System;

namespace ClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.ProductName = "Deneme Ürünüdür";
            product1.UnitPrice = 7.85;
            product1.Stock = 5;
            product1.Barcode = "86896312588";
            Product product2 = new Product();
            product2.ProductName = "Test Ürünüdür";
            product2.UnitPrice = 11.85;
            product2.Stock = 13;
            product2.Barcode = "86896312599";
            Product product3 = new Product();
            product3.ProductName = "Deneme2 Ürünüdür";
            product3.UnitPrice = 17.85;
            product3.Stock = 15;
            product3.Barcode = "86896312587";
            Product product4 = new Product();
            product4.ProductName = "Test2 Ürünüdür";
            product4.UnitPrice = 13.85;
            product4.Stock = 26;
            product4.Barcode = "86896312595";

            Product[] products = new Product[] { product1, product2, product3, product4 };
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + ":" + products[i].UnitPrice + ":" + products[i].Stock + ":" + products[i].Barcode);

            }
            Console.WriteLine("---for------------");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + ":" + product.UnitPrice + ":" + product.Stock + ":" + product.Barcode);
            }
            Console.WriteLine("--------foreach------------");

            var a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].ProductName + ":" + products[a].UnitPrice + ":" + products[a].Stock + ":" + products[a].Barcode);
                a++;
            }
            Console.WriteLine("----------while-------------");

        }
    }



    class Product
    {
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }


    }




}
