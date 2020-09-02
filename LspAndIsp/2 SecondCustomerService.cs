using Shared;
using System;
using System.Collections.Generic;

namespace LspAndIsp
{
    public class SecondCustomerService: ICustomerService, ICustomerShoppingCartService
    {
        public Customer GetCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer AddCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        // maybe?
        public List<string> AddToShoppingCart(int customerId, string product)
        {
            throw new NotImplementedException();
        }
    }

    public class CustomerRankingService : ICustomerRankService
    {
        public List<Customer> RankCustomersByFeedback(string product)
        {
            throw new NotImplementedException();
        }

        public List<Customer> RankCustomersByProduct(string product)
        {
            throw new NotImplementedException();
        }

        public List<Customer> RankCustomersByRegion(string region)
        {
            throw new NotImplementedException();
        }
    }
}
