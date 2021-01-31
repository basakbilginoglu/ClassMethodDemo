using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void ToList(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+ " " + customer.CustomerSurname);
             
            Console.ReadKey();
        }
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname+" "+"Sistemimize eklendi"+"\n");
            Console.ReadKey();
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(  customer.CustomerName +"|"
               + customer.CustomerSurname +" "+"Müşteri sistemden silindi"+"\n");
            Console.ReadKey();
        }
    }
}
