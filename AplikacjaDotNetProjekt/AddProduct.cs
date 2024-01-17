using AddProductLibrary;
using AddProductLibrary.API;
using AplikacjaDotNetProjekt.Database;
using AplikacjaDotNetProjekt.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaDotNetProjekt
{
    public partial class AddProduct : Form
    {
        List<string> sourceList = new List<string> { "Add new product", "Choose from database", "API" };
        List<ProductModel> productList;
        private Database.Services.ProductService _productService;
        string query;
        public event Action<float, Product> ProductAdded;
        Product selectedProduct;


        public AddProduct()
        {
            InitializeComponent();

            foreach (string source in sourceList)
            {
                selectSource_combo.Items.Add(source);
            }
            selectSource_combo.SelectedIndexChanged += SelectSource_combo_selectedIndexChange;
            _productService = new Database.Services.ProductService(new DBContext());

        }

        private void SelectSource_combo_selectedIndexChange(Object sender, EventArgs e)
        {
            string selectedSource = selectSource_combo.SelectedIndex.ToString();
            log_label.Text = "";
            ClearPage();

            switch (selectedSource)
            {
                case "0":
                    GetNewProduct();
                    break;
                case "1":
                    GetAllProductsAndDisplayAsync();
                    break;
                case "2":
                    GetProductFromAPI();
                    break;

                default:
                    selectProductSource_label.Text = "Brak";
                    break;

            }
        }
        private void ClearPage()
        {
            // Clear page after API
            writeProductAPI_label.Visible = false;
            writeProductAPI_textBox.Visible = false;
            searchAPI_button.Visible = false;
            apiResult_label.Visible = false;
            apiResult_label.Text = "";
            entryGramAPI_textBox.Visible = false;
            gAPI_label.Visible = false;
            weightAPI_label.Visible = false;
            nutriments_table.Visible = false;
            nutriments_table.Rows.Clear();
            addProduct_button.Visible = false;

            //Clear page after all product
            selectProduct_combo.Visible = false;
            chooseProduct_label.Visible = false;
            productInfo_table.Visible = false;
            productInfo_label.Visible = false;
            weightChoose_label.Visible = false;
            gChoose_label.Visible = false;
            entryGramChoose_textBox.Visible = false;
            addProductChoose_button.Visible = false;

            //Clear page after new product
            nameNewProduct_label.Visible = false;
            nameNewProduct_textBox.Visible = false;
            kcalNewProduct_label.Visible = false;
            kcalNewProduct_textBox.Visible = false;
            fatNewProduct_label.Visible = false;
            fatNewProduct_textBox.Visible = false;
            gFat_label.Visible = false;
            carbohydratesNewProduct_label.Visible = false;
            carbohydratesNewProduct_textBox.Visible = false;
            gCarbohydrates_label.Visible = false;
            fiberNewProduct_label.Visible = false;
            fiberNewProduct_textBox.Visible = false;
            gFiber_label.Visible = false;
            proteinNewProduct_label.Visible = false;
            proteinNewProduct_textBox.Visible = false;
            gProtein_label.Visible = false;
            saltNewProduct_label.Visible = false;
            saltNewProduct_textBox.Visible = false;
            gSalt_label.Visible = false;
            weightNewProduct_label.Visible = false;
            entryWeightNewProduct_textBox.Visible = false;
            gWeightNewProduct_label.Visible = false;
            addProductNewProduct_button.Visible = false;
            newProduct_label.Visible = false;
            logNewProduct_label.Text = "";
            log_label.Text = "";


        }

        private void GetProductFromAPI()
        {
            writeProductAPI_textBox.Clear();
            writeProductAPI_label.Visible = true;
            writeProductAPI_textBox.Visible = true;
            searchAPI_button.Visible = true;
            apiResult_label.Visible = true;
        }

        private async void searchAPI_button_Click(object sender, EventArgs e)
        {
            query = writeProductAPI_textBox.Text.Trim();

            ProductSearch productSearch = new ProductSearch(query);
            productList = await productSearch.getAPI(log_label);
            DisplayProductList(productList);

        }

        private void DisplayProductList(List<ProductModel> products)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => DisplayProductList(products)));
                return;
            }

            // Oczyszczenie poprzednich danych z etykiet
            if (products != null && products.Count > 0)
            {
                if (products[0].ProductName == "")
                {
                    products[0].ProductName = query;
                }
                apiResult_label.Text = $"Product Name: {products[0].ProductName}{Environment.NewLine}";

                weightAPI_label.Visible = true;
                gAPI_label.Visible = true;
                entryGramAPI_textBox.Visible = true;

                updateNutrimentsTable(products[0]);
            }
            else
            {
                apiResult_label.Text = "No products found.";
                weightAPI_label.Visible = false;
                gAPI_label.Visible = false;
                entryGramAPI_textBox.Visible = false;
                nutriments_table.Visible = false;
                addProduct_button.Visible = false;
            }

        }

        private void entryWeightAPI_textChanged(object sender, EventArgs e)
        {
            updateNutrimentsTable(productList[0]);
        }

        private void updateNutrimentsTable(ProductModel product)
        {
            string weightText = entryGramAPI_textBox.Text.Trim();
            if (int.TryParse(weightText, out int weight))
            {
                log_label.Text = "";
                nutriments_table.Rows.Clear();

                // Dodawanie nowego wiersza do DataGridView
                nutriments_table.Rows.Add("Energy Kcal", productList[0].nutriments.EnergyKcal * weight / 100);
                nutriments_table.Rows.Add("Fat", productList[0].nutriments.Fat * weight / 100);
                nutriments_table.Rows.Add("Carbohydrates", productList[0].nutriments.Carbohydrates * weight / 100);
                nutriments_table.Rows.Add("Fiber", productList[0].nutriments.Fiber * weight / 100);
                nutriments_table.Rows.Add("Protein", productList[0].nutriments.Protein * weight / 100);
                nutriments_table.Rows.Add("Salt", productList[0].nutriments.Salt * weight / 100);


                nutriments_table.Visible = true;
                addProduct_button.Visible = true;

            }
            else
            {
                log_label.Text = "Error: incorrect weight entered";
            }
        }

        private void addProduct_button_Click(object sender, EventArgs e)
        {
            if (productList != null && productList.Count > 0)
            {
                ProductModel productModel = productList[0];


                if (_productService.DoesProductExist(productModel.ProductName))
                {
                    log_label.Text = $"Product name = {productModel.ProductName} already exixsts.";
                }
                else
                {
                    string productWeight = entryGramAPI_textBox.Text.Trim();

                    if (!float.TryParse(productWeight, out float weight))
                    {
                        log_label.Visible = true;
                        log_label.Text = "Error: invalid weight format";
                        return;
                    }
                    Product productToAdd = new Product
                    {
                        Nazwa = productModel.ProductName,
                        EnergyKcal = productModel.nutriments.EnergyKcal,
                        Fat = productModel.nutriments.Fat,
                        Carbohydrates = productModel.nutriments.Carbohydrates,
                        Fiber = productModel.nutriments.Fiber,
                        Protein = productModel.nutriments.Protein,
                        Salt = productModel.nutriments.Salt
                    };

                    // Dodaj produkt do bazy danych
                    int idProduct = _productService.AddProductToDatabase(productToAdd);
                    if (idProduct < 0)
                    {
                        log_label.Text = $"Error: the product has not been added";

                    }
                    else
                    {
                        log_label.Text = $"Product with id = {idProduct} successfully added";
                        ProductAdded?.Invoke(weight, productToAdd);

                    }

                }
            }
            else
            {
                log_label.Text = "Nie udało sie";
            }
        }

        private void log_label_Resize(object sender, EventArgs e)
        {
            int containerWidth = this.Width; // Zastąp to kontrolką, której szerokość ma być brana pod uwagę
            int labelWidth = log_label.Width;

            int newX = (containerWidth - labelWidth) / 2;
            log_label.Location = new Point(newX, log_label.Location.Y);
        }
        private async void GetAllProductsAndDisplayAsync()
        {
            List<Product> allProducts = await _productService.GetAllProductsAsync();
            ClearPage();

            if (allProducts != null && allProducts.Count > 0)
            {
                List<string> productNames = allProducts.Select(product => product.Nazwa).Distinct().ToList();
                selectProduct_combo.Items.Clear();
                // Dodaj unikalne nazwy do rozwijanej listy
                selectProduct_combo.Items.AddRange(productNames.ToArray());

                chooseProduct_label.Visible = true;
                selectProduct_combo.Visible = true;
            }
            else
            {
                // Brak produktów w bazie danych
                log_label.Text = ("Brak produktów w bazie danych.");
            }
        }

        private void selectProduct_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = selectProduct_combo.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedProductName))
            {
                DisplayProductInfo(selectedProductName);
            }
        }

        private void DisplayProductInfo(string selectedProductName)
        {
            // Pobierz informacje o wybranym produkcie
            selectedProduct = _productService.GetProductByName(selectedProductName);

            if (selectedProduct != null)
            {
                productInfo_table.Rows.Clear();

                // Dodawanie nowego wiersza do DataGridView
                productInfo_table.Rows.Add("Product name", selectedProduct.Nazwa);
                productInfo_table.Rows.Add("Energy Kcal", selectedProduct.EnergyKcal);
                productInfo_table.Rows.Add("Fat", selectedProduct.Fat);
                productInfo_table.Rows.Add("Carbohydrates", selectedProduct.Carbohydrates);
                productInfo_table.Rows.Add("Fiber", selectedProduct.Fiber);
                productInfo_table.Rows.Add("Protein", selectedProduct.Protein);
                productInfo_table.Rows.Add("Salt", selectedProduct.Salt);

                productInfo_table.Visible = true;
                productInfo_label.Visible = true;
                weightChoose_label.Visible = true;
                entryGramChoose_textBox.Visible = true;
                gChoose_label.Visible = true;
                addProductChoose_button.Visible = true;
            }
            else
            {
                // Produkt o podanej nazwie nie został znaleziony
                log_label.Text = "Nie znaleziono informacji o produkcie.";
            }
        }

        private void addProductChoose_button_Click(object sender, EventArgs e)
        {
            string productWeight = entryGramChoose_textBox.Text.Trim();

            if (!float.TryParse(productWeight, out float weight))
            {
                log_label.Visible = true;
                log_label.Text = "Error: invalid weight format";
                return;
            }

            ProductAdded?.Invoke(weight, selectedProduct);


        }
        private async void GetNewProduct()
        {
            logNewProduct_label.Text = "";
            nameNewProduct_label.Visible = true;
            nameNewProduct_textBox.Visible = true;
            kcalNewProduct_label.Visible = true;
            kcalNewProduct_textBox.Visible = true;
            fatNewProduct_label.Visible = true;
            fatNewProduct_textBox.Visible = true;
            gFat_label.Visible = true;
            carbohydratesNewProduct_label.Visible = true;
            carbohydratesNewProduct_textBox.Visible = true;
            gCarbohydrates_label.Visible = true;
            fiberNewProduct_label.Visible = true;
            fiberNewProduct_textBox.Visible = true;
            gFiber_label.Visible = true;
            proteinNewProduct_label.Visible = true;
            proteinNewProduct_textBox.Visible = true;
            gProtein_label.Visible = true;
            saltNewProduct_label.Visible = true;
            saltNewProduct_textBox.Visible = true;
            gSalt_label.Visible = true;
            weightNewProduct_label.Visible = true;
            entryWeightNewProduct_textBox.Visible = true;
            gWeightNewProduct_label.Visible = true;
            addProductNewProduct_button.Visible = true;
            newProduct_label.Visible = true;

        }

        private void addProductNewProduct_button_Click(object sender, EventArgs e)
        {
            string productName = nameNewProduct_textBox.Text.Trim();
            string productKcal = kcalNewProduct_textBox.Text.Trim();
            string productFat = fatNewProduct_textBox.Text.Trim();
            string productCarbo = carbohydratesNewProduct_textBox.Text.Trim();
            string productFiber = fiberNewProduct_textBox.Text.Trim();
            string productProtein = proteinNewProduct_textBox.Text.Trim();
            string productSalt = saltNewProduct_textBox.Text.Trim();
            string productWeight = entryWeightNewProduct_textBox.Text.Trim();

            // Walidacja wprowadzonych danych
            if (string.IsNullOrEmpty(productName))
            {
                logNewProduct_label.Visible = true;
                logNewProduct_label.Text = "Error: product name is required";
                return;
            }

            if (!float.TryParse(productKcal, out float kcal) || !float.TryParse(productFat, out float fat) ||
                !float.TryParse(productCarbo, out float carbo) || !float.TryParse(productFiber, out float fiber) ||
                !float.TryParse(productProtein, out float protein) || !float.TryParse(productSalt, out float salt))
            {
                logNewProduct_label.Visible = true;
                logNewProduct_label.Text = "Error: invalid numeric format";
                return;
            }

            if (!float.TryParse(productWeight, out float weight))
            {
                logNewProduct_label.Visible = true;
                logNewProduct_label.Text = "Error: invalid weight format";
                return;
            }
            if (_productService.DoesProductExist(productName))
            {
                logNewProduct_label.Visible = true;
                logNewProduct_label.Text = $"Product name = {productName} already exixsts.";
                return;
            }

            // Poniżej możesz użyć pobranych wartości do dalszych operacji, np. dodania produktu do bazy danych
            // ...

            // Przykładowa akcja: dodanie produktu do bazy danych
            Product newProduct = new Product
            {
                Nazwa = productName,
                EnergyKcal = kcal,
                Fat = fat,
                Carbohydrates = carbo,
                Fiber = fiber,
                Protein = protein,
                Salt = salt
            };

            // Wywołaj odpowiednią funkcję do dodawania produktu do bazy danych
            int idProduct = _productService.AddProductToDatabase(newProduct);
            if (idProduct < 0)
            {
                logNewProduct_label.Text = $"Error: the product has not been added";

            }
            else
            {
                logNewProduct_label.Text = $"Product with id = {idProduct} successfully added";
                ProductAdded?.Invoke(weight, newProduct);
            }
            logNewProduct_label.Visible = true;
        }
        private void logNewProduct_resize(object sender, EventArgs e)
        {
            int containerWidth = this.Width; // Zastąp to kontrolką, której szerokość ma być brana pod uwagę
            int labelWidth = logNewProduct_label.Width;

            int newX = (containerWidth - labelWidth) / 2;
            logNewProduct_label.Location = new Point(newX, logNewProduct_label.Location.Y);
        }
    }
}
