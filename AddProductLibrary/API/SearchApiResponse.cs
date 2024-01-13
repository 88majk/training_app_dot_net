using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProductLibrary.API
{
    public class SearchApiResponse
    {
        [JsonProperty("products")]
        public List<ProductModel> Products { get; set; }
    }
}
