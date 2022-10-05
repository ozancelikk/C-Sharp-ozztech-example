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
            customer.Id = 1;
            customer.FirstName = "ozan";
            customer.LastName = "çelik";
            customer.City = "istanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "max",
                LastName = "Verstappen",
                City = "Holland"
            };
            Console.WriteLine(customer2.FirstName);

        }
    }
}
