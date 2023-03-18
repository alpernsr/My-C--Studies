using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
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
            customer.Name = "Simge";
            customer.LastName = "Manti";
            customer.City = "Kars";

            Customer customer1 = new Customer()
            {
                Id = 2,
                City = "Canakkale",
                Name = "Simge",
                LastName = "Sürmeli"
            };
            

            Console.ReadLine();
        }
    }
    
}
   

    
