namespace BlazorApp2.DB
{
    public class conexionDB
    {
        public conexionDB(string connectionString) => ConnectionString = connectionString;
        public string ConnectionString { get; }
    }
}
