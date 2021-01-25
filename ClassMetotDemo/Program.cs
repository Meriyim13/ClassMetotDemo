using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Merve";
            customer1.LastName = "Can";

            Customer customer2 = new Customer { Id = 2, FirstName = "Damla", LastName = "Yılmaz" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mevsim";
            customer3.LastName = "Beğen";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("-------EKLEME----------");

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            List<string> custom = new List<string>();
            customerManager.List(customers);

            Console.WriteLine("--------LİSTELEME-------");


            customerManager.Delete(customer1);
            Console.WriteLine("--------SİLME-------");


        }
    }
}
