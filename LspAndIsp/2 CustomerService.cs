using Shared;
using System;
using System.Collections.Generic;

namespace LspAndIsp
{
    public class CustomerService : ICustomerService, ICustomerFeedbackService, ICustomerRankService, ICustomerSearchService, ICustomerShoppingCartService, ICustomerTaxService
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

        public List<string> AddToShoppingCart(int customerId, string product)
        {
            throw new NotImplementedException();
        }

        public List<string> CalculateCustomerTaxRecords(int customerId)
        {
            throw new NotImplementedException();
        }


        public List<string> GetCustomerFeedback()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersByProductGroup()
        {
            throw new NotImplementedException();
        }

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

    public interface ICustomerService
    {
        Customer AddCustomer(Customer c);
        Customer GetCustomer();
        void RemoveCustomer(Customer c);
        Customer UpdateCustomer(Customer c);
    }


    public interface ICustomerRankService
    {
        List<Customer> RankCustomersByFeedback(string product);
        List<Customer> RankCustomersByProduct(string product);
        List<Customer> RankCustomersByRegion(string region);
    }

    public interface ICustomerSearchService
    {
        List<Customer> GetCustomersByLocation(string location);
        List<Customer> GetCustomersByProductGroup();
    }

    public interface ICustomerShoppingCartService
    {
        List<string> AddToShoppingCart(int customerId, string product);
    }

    public interface ICustomerFeedbackService
    {
        List<string> GetCustomerFeedback();
    }

    public interface ICustomerTaxService
    {
        List<string> CalculateCustomerTaxRecords(int customerId);
    }
}
