using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Text.Json;

namespace Infrastructure.Adapters
{
    public interface IJsonConverter
    {
        string ConvertToJson(List<Product> products);
    }

    public class JsonAdapter : IJsonConverter
    {
        public string ConvertToJson(List<Product> products)
        {
            return JsonSerializer.Serialize(products);
        }
    }
}