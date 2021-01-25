using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer )
        {
            Console.WriteLine(customer.FirstName +""+ customer.LastName + ""+ "Müşteri başarılı bir şekilde eklendi.");
        }

        public void List(Customer[] customers)
        {
            
            foreach (var custom in customers)
            {
                Console.WriteLine(custom.FirstName + " " + custom.LastName );
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName +"" +customer.LastName +":" +"Müşterisi Silindi.");
        }

    }
}
