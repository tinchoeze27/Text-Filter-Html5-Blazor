using Microsoft.Data.Sqlite;

namespace BlazorApp2.Data
{
    public static class sqlite
    {
        static string connection = @"Data Source=productos.db;Pooling=True;";

        public static List<productsModel> productos(string texto)
        {
            List<productsModel> resultado = new List<productsModel>();
            productsModel p;
            string st = "select codigo,descripcion from productos where codigo like '" + texto + "%' limit 15";
            using var con = new SqliteConnection(connection);
            con.Open();
            using var cmd = new SqliteCommand(st,con);
            SqliteDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                p = new productsModel();
                p.Codigo = read.GetString(0);
                p.Descripcion = read.GetString(1);
                resultado.Add(p);
            }

            con.Close();
            return resultado;

        }
    }
}
