using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProductLibrary.API
{
    public class ProductSearch
    {
        private string query;
        private const string ApiBaseUrl = "https://world.openfoodfacts.net/api/v2";
        public ProductSearch(string query) 
        {
            this.query = query;
        }

        public async Task<List<ProductModel>> getAPI(Label label)
        {
            if (!string.IsNullOrEmpty(query))
            {
                List<ProductModel> products = await SearchProducts(query);

                if (products != null && products.Count > 0)
                {
                    label.Text = products[0].ProductName;
                    return products;
                }
                else
                {
                    label.Text = ("No products found for the given query.");
                }
            }
            else
            {
                label.Text = ("Please enter a valid search query.");
            }
            return new List<ProductModel>();
        }

        private async Task<List<ProductModel>> SearchProducts(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ApiBaseUrl}/search?fields=product_name&categories_tags_en={query}&page_size=10";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    SearchApiResponse apiResponse = JsonConvert.DeserializeObject<SearchApiResponse>(jsonResult);

                    if (apiResponse?.Products != null)
                    {
                        return apiResponse.Products;
                    }
                }
            }

            return null;
        }
    }
}
