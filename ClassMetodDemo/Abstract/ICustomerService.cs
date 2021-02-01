using System;
using System.Collections.Generic;
using ClassMetodDemo.Models;

namespace ClassMetodDemo.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        void Add(Customer customer);

        void Delete(Customer customer);

        void Update(Customer customer);
    }
}
