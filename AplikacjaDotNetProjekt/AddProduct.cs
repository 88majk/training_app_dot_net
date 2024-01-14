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
                    selectProductSource_label.Text = sourceList[0];
                    break;
                case "1":
                    selectProductSource_label.Text = sourceList[1];
                    break;
                case "2":
                    GetProductFromAPI();
                    selectProductSource_label.Text = sourceList[2];
                    break;

                default:
                    selectProductSource_label.Text = "Brak";
                    break;

            }
        }
        private void ClearPage()
        {
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
                    log_label.Text = $"Produkt o nazwie {productModel.ProductName} już istnieje.";
                }
                else
                {


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
                    log_label.Text = $"Product with id = {idProduct} successfully added";
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
    }
}
