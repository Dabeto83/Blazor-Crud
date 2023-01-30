using BlazorCRUD.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BlazorCRUD.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private string _connectionString;

        public CustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection Connection()
        {
            return new SqlConnection(_connectionString);
        }
        public async Task<bool> SaveCustomer(Customer customer)
        {
            bool createdCustomer = false;
            SqlConnection sqlConnection = Connection();
            SqlCommand command = null;
            try
            {
                sqlConnection.Open();
                command = sqlConnection.CreateCommand();
                command.CommandText = "dbo.UsuarioAlta";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar, 500).Value = customer.Nombre;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 500).Value = customer.Email;
                command.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value = customer.Telefono;
                command.Parameters.Add("@FechaAlta", SqlDbType.DateTime).Value = DateTime.Now;

                await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                createdCustomer = true;
            }
            finally
            {
                command.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            return createdCustomer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            SqlConnection sqlConnection = Connection();
            SqlCommand command = null;

            List<Customer> customers = new List<Customer>();

            try
            {
                sqlConnection.Open();
                command = sqlConnection.CreateCommand();
                command.CommandText = "UsuariosLista";
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.Nombre = reader["Nombre"].ToString();
                    customer.Email = reader["Email"].ToString();
                    customer.Telefono = reader["Telefono"].ToString();
                    customers.Add(customer);
                }
                reader.Close();
            }
            finally
            {
                command.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            return customers;
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            SqlConnection sqlConnection = Connection();
            SqlCommand sqlCommand = null;

            try
            {
                sqlConnection.Open();
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "ObtenerUsuarioPorId";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdCliente", SqlDbType.Int).Value = customerId;

                Customer customer = new Customer();

                SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (reader.Read())
                {
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.Nombre = reader["Nombre"].ToString();
                    customer.Email = reader["Email"].ToString();
                    customer.Telefono = reader["Telefono"].ToString();
                }
                return customer;
            }
            finally
            {
                sqlCommand.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            bool updatedCustomer = false;
            SqlConnection sqlConnection = Connection();
            SqlCommand sqlCommand = null;
            try
            {
                sqlConnection.Open();
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "ActualizatUsuario";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdCliente", SqlDbType.Int).Value = customer.Id;
                sqlCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 500).Value = customer.Nombre;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 500).Value = customer.Email;
                sqlCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = customer.Telefono;

                var result = await sqlCommand.ExecuteNonQueryAsync().ConfigureAwait(false);
                updatedCustomer = true;
            }
            finally
            {
                sqlCommand.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();

            }
            return updatedCustomer;
        }

        public async Task<bool> DeleteCustomer(int customerId)
        {
            SqlConnection sqlConnection = Connection();
            SqlCommand sqlCommand = null;
            bool deletedCustomer = false;

            try
            {
                sqlConnection.Open();
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "BorrarCliente";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@IdCliente", SqlDbType.Int).Value = customerId;

                var result = await sqlCommand.ExecuteNonQueryAsync();
                deletedCustomer = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"An issue has been raised when deleting customer {ex}");
            }
            finally
            {
                sqlCommand.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }

            return deletedCustomer;
        }
    }
}
