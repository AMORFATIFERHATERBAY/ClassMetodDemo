using System;
using System.Collections.Generic;
using System.Linq;
using ClassMetodDemo.Abstract;
using ClassMetodDemo.Models;

namespace ClassMetodDemo.Concrete
{
    public class CustomerManager :ICustomerService
    {
        List<Customer> _customer;

        public CustomerManager()
        {
            _customer = new List<Customer> {
                new Customer { Id=1111, FirstName="Jess", LastName="Boony"}, 
                new Customer { Id=1112, FirstName="Murray", LastName="Anthony"}, 
                new Customer { Id=1113, FirstName="Alan", LastName="Green"}, 
                new Customer { Id=1114, FirstName="Poe", LastName="Brown"} };
        }

        public void Add(Customer customer)
        {
            _customer.Add(customer);
        }

        public void Delete(Customer customer)
        {
          

            Customer customer1 = _customer.SingleOrDefault(c => c.Id == customer.Id);
            _customer.Remove(customer1);
            
        }

        public List<Customer> GetAll()
        {
            return _customer;
        }

        public void Update(Customer customer)
        {
            Customer customer1 = _customer.SingleOrDefault(c => c.Id == customer.Id);
            if (customer1!=null)
            {
                customer1.FirstName = customer.FirstName;
                customer1.LastName = customer.LastName;
            }
            else
            {
                Console.WriteLine("Warning Message : Invalid Customer.");
            }
            

        }
    }
}
