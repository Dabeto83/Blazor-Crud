using BlazorCRUD.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Interfaces
{
    public interface ICustomerService
    {
        Task<bool> SaveCustomer(Customer customer);

        Task<IEnumerable<Customer>> GetCustomers();

        Task<Customer> GetCustomerById(int customerId);

        Task<bool> DeleteCustomer(int customerId);
    }
}
