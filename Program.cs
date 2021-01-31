using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            {
                customer1.CustomeriId = 1;
                customer1.CustoemrTc = "1234567890";
                customer1.CustomerName = "Ayşe";
                customer1.CustomerSurname = "Ali";

                customer1.CustomerNumber = "12345";
            }

            Customer customer2 = new Customer();
            {
                customer2.CustomeriId = 2;
                customer2.CustoemrTc = "1234567899";
                customer2.CustomerName = "Fatma";
                customer2.CustomerSurname = "Aliye";

                customer2.CustomerNumber = "12245";
            }

            Customer customer3 = new Customer();
            {
                customer3.CustomeriId = 3;
                customer3.CustoemrTc = "1234567898";
                customer3.CustomerName = "Ayhan";
                customer3.CustomerSurname = "Öz";

                customer3.CustomerNumber = "12745";
            }


            Customer customer4 = new Customer();
            {
                customer4.CustomeriId = 4;
                customer4.CustoemrTc = "1234567899";
                customer4.CustomerName = "Kadir";
                customer4.CustomerSurname = "Ser";

                customer4.CustomerNumber = "12749";
            }


            Customer[] customers = new Customer[] { customer1,customer2,customer3,customer4};
            CustomerManager musteriManager = new CustomerManager();

            for (int i = 0; i < customers.Length; i++)
            {
            musteriManager.Add(customers[i]);
            }

          
            musteriManager.Delete(customer3);

           Console.WriteLine("Sistemimizdeki müşteriler:");
           foreach (var customer in customers)
           {
                musteriManager.ToList(customer);
           }


            Console.ReadKey();
        }
         
        }
    }

