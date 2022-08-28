using BlazorApp2.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BlazorApp2.DB
{
    public class MongoBD: IMongoDB
    {
        private readonly conexionDB connection;
        public string connectionString = "";

        public MongoBD(conexionDB configuracion)
        {
            connection = configuracion;
            connectionString = connection.ConnectionString;
        }

        public List<productsModel> GetItemsMongoDB(string texto)
        {
            var filter = Builders<productsModel>.Filter.Regex("Codigo",new BsonRegularExpression(texto, "i"));
            var cliente = new MongoClient(connectionString);
            var database = cliente.GetDatabase("testdb");
            var items = database.GetCollection<productsModel>("productos").Find(filter).Limit(10).ToList();
            //var items = database.GetCollection<productsModel>("productos").Find(new BsonDocument { { "Codigo", new BsonDocument { { "$regex", texto + "*i"} }}}).ToList();
            return items;
        }
    }
}
