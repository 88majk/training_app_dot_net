using AddProductLibrary;
using AddProductLibrary.API;
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


        public AddProduct()
        {
            InitializeComponent();

            foreach (string source in sourceList)
            {
                selectSource_combo.Items.Add(source);
            }
            selectSource_combo.SelectedIndexChanged += SelectSource_combo_selectedIndexChange;
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
            string query = writeProductAPI_textBox.Text.Trim();

            ProductSearch productSearch = new ProductSearch(query);
            List<ProductModel> productList = await productSearch.getAPI(log_label);
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
            apiResult_label.Text = "";
            apiResult_label.Text += $"Product Name: {products[0].ProductName}{Environment.NewLine}";

        }
    }
}
