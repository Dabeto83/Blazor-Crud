namespace BlazorCRUD.Data
{
    public class SqlConfiguration
    {
        private string _connectionString;

        public string ConnectionString { get => _connectionString; }

        public SqlConfiguration(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
