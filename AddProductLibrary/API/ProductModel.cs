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

        [JsonProperty("nutriments")]
        public Nutriments nutriments { get; set; }

        public class Nutriments
        {
            [JsonProperty("energy-kcal_100g")]
            public float EnergyKcal { get; set; }

            [JsonProperty("fat_100g")]
            public float Fat { get; set; }

            [JsonProperty("carbohydrates_100g")]
            public float Carbohydrates { get; set; }

            [JsonProperty("fruits-vegetables-legumes-estimate-from-ingredients_100g")]
            public float Fiber { get; set; }

            [JsonProperty("proteins_100g")]
            public float Protein { get; set; }

            [JsonProperty("salt_100g")]
            public float Salt { get; set; }
        }
    }
}
