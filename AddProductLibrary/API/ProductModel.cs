using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AddProductLibrary
{
    public class ProductModel
    {
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
    }
}
