using BlazorCRUD.Data;
using BlazorCRUD.Interfaces;
using BlazorCRUD.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;
        private readonly SqlConfiguration _sqlConfiguration;

        public CustomerService(SqlConfiguration sqlConfiguration)
        {
            _sqlConfiguration = sqlConfiguration;
            _customerRepository = new CustomerRepository(_sqlConfiguration.ConnectionString);
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            return await _customerRepository.GetCustomerById(customerId).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _customerRepository.GetCustomers().ConfigureAwait(false);
        }

        public async Task<bool> SaveCustomer(Customer customer)
        {
            if (customer.Id == 0)
                return await _customerRepository.SaveCustomer(customer).ConfigureAwait(false);
            else
                return await _customerRepository.UpdateCustomer(customer).ConfigureAwait(false);
        }

        public async Task<bool> DeleteCustomer(int customerId) 
        {
            return await _customerRepository.DeleteCustomer(customerId).ConfigureAwait(false);
        }

    }
}
