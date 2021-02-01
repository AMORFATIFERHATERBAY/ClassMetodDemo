using System;
using ClassMetodDemo.Concrete;
using ClassMetodDemo.Models;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
                
            customerManager.Add(new Customer { Id = 1115, FirstName = "Jack", LastName = "Bill" });
            customerManager.Delete(new Customer { Id = 1113, FirstName = "Alan", LastName = "Green" });
            customerManager.Update(new Customer { Id = 1114, FirstName = "Ali", LastName = "Yesil" });


            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.Id+" "+customer.FirstName+" "+customer.LastName);
            }
        }
    }
}
