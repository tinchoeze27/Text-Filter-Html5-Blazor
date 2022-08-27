using BlazorApp2.Models;

namespace BlazorApp2.DB
{
    public interface IMongoDB
    {
        public List<productsModel>GetItemsMongoDB(string texto);
    }
}
