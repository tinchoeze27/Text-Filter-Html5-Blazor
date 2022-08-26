using Newtonsoft.Json;

namespace BlazorApp2.Data
{
    public class productsModel
    {
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }
    }
}
