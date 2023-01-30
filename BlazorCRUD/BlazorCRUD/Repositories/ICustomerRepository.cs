using BlazorCRUD.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Repositories
{
    public interface ICustomerRepository
    {

        Task<bool> SaveCustomer(Customer customer);

        Task<IEnumerable<Customer>> GetCustomers();

        Task<Customer> GetCustomerById(int customerId);

        Task<bool> UpdateCustomer(Customer customer);

        Task<bool> DeleteCustomer(int customerId);

    }
}
