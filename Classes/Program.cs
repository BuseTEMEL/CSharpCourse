using System;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Özkan";
            customer.Lastname = "Toraman";

            Customer customer2 = new Customer
            {
                City = "İstanbul", Id = 2, FirstName = "Buse", Lastname = "Temel"
            };
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer.Lastname);

            Console.ReadLine();
        }
    }

    

    
    
}
