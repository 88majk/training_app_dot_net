using AddProductLibrary;
using AplikacjaDotNetProjekt.Database.Models;
using AplikacjaDotNetProjekt.Database.Services;
using AplikacjaDotNetProjekt.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AplikacjaDotNetProjekt
{
    public partial class AddMeal : Form
    {
        AddProduct addProduct;
        List<Product> productList;
        List<float> weightList;
        private Database.Services.MealService _mealService;
        List<string> typeMealList = new List<string>() { "Breakfast", "Brunch", "Dinner", "Dessert", "Lunch", "Supper", "Snack" };
        private Database.Services.ProductService productService = new Database.Services.ProductService(new DBContext());


        private void AddMeal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addProduct != null && !addProduct.IsDisposed)
            {
                addProduct.Close();
            }
        }

        public AddMeal()
        {
            InitializeComponent();
            productList = new List<Product>();
            weightList = new List<float>();
            this.FormClosing += AddMeal_FormClosing;

            mealType_combobox.Items.AddRange(typeMealList.ToArray());
            _mealService = new Database.Services.MealService(new DBContext());

        }

        private void addProduct_button_Click(object sender, EventArgs e)
        {
            if (addProduct == null || addProduct.IsDisposed)
            {
                addProduct = new AddProduct();
                addProduct.ProductAdded += AddProductToList;
                addProduct.Show();
            }
            else
            {
                if (addProduct.WindowState == FormWindowState.Minimized)
                {
                    addProduct.WindowState = FormWindowState.Normal;
                }

                addProduct.BringToFront();
                addProduct.Focus();
            }
        }

        public void AddProductToList(float weight, Product product)
        {
            productList.Add(product);
            weightList.Add(weight);
            log_label.Text = "";

            // Dodawanie nowego wiersza do DataGridView
            product_table.Rows.Add(product.Nazwa, weight);

            // Sprawdzenie, czy to pierwszy produkt
            if (productList.Count == 1)
            {
                // To pierwszy produkt, dodaj nutriments do tabeli nutriments_table
                nutriments_table.Rows.Add("Energy Kcal", product.EnergyKcal * weight / 100);
                nutriments_table.Rows.Add("Fat", product.Fat * weight / 100);
                nutriments_table.Rows.Add("Carbohydrates", product.Carbohydrates * weight / 100);
                nutriments_table.Rows.Add("Fiber", product.Fiber * weight / 100);
                nutriments_table.Rows.Add("Protein", product.Protein * weight / 100);
                nutriments_table.Rows.Add("Salt", product.Salt * weight / 100);
            }
            else
            {
                nutriments_table.Rows[0].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["NutrimentsValue"].Value) + (product.EnergyKcal * weight / 100), 2);
                nutriments_table.Rows[1].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[1].Cells["NutrimentsValue"].Value) + (product.Fat * weight / 100), 2);
                nutriments_table.Rows[2].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[2].Cells["NutrimentsValue"].Value) + (product.Carbohydrates * weight / 100), 2);
                nutriments_table.Rows[3].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[3].Cells["NutrimentsValue"].Value) + (product.Fiber * weight / 100), 2);
                nutriments_table.Rows[4].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[4].Cells["NutrimentsValue"].Value) + (product.Protein * weight / 100), 2);
                nutriments_table.Rows[5].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[5].Cells["NutrimentsValue"].Value) + (product.Salt * weight / 100), 2);


            }
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            log_label.Text = "";
            string mealName = mealEnter_textBox.Text.Trim();
            string mealType = mealType_combobox.Text.Trim();

            if (string.IsNullOrEmpty(mealName))
            {
                log_label.Visible = true;
                log_label.Text = "Error: meal name is required";
                return;
            }
            if (string.IsNullOrEmpty(mealType))
            {
                log_label.Visible = true;
                log_label.Text = "Error: meal type is required";
                return;
            }
            if (weightList != null && weightList.Count > 0 && productList != null && productList.Count > 0)
            {
                Meal meal = new Meal();
                {
                    meal.Name = mealName;
                    meal.Meal_type = mealType;
                }
                int mealId = _mealService.AddMealToDatabase(meal, productList, weightList);

                if (mealId == -1)
                {
                    log_label.Visible = true;
                    log_label.Text = "Error: the meal has not been added";
                    return;
                }
                else if (mealId == -2)
                {
                    log_label.Visible = true;
                    log_label.Text = "Error: Name of the meal already exists";
                    return;
                }
                else
                {
                    log_label.Visible = true;
                    log_label.Text = $"the product was added with id = {mealId}";
                    return;
                }
            }
            else
            {
                log_label.Text = "Error: add product first";
                return;
            }

        }

        private void product_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pobierz dane zaznaczonego wiersza
                string productName = product_table.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                float weight = Convert.ToSingle(product_table.Rows[e.RowIndex].Cells["ProductWeight"].Value);
                Product foundProduct = productList.FirstOrDefault(p => p.Nazwa == productName);

                if (foundProduct == null)
                {
                    log_label.Text = "Product not found";
                    return;
                }

                nutriments_table.Rows[0].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["NutrimentsValue"].Value) - (foundProduct.EnergyKcal * weight / 100), 2);
                nutriments_table.Rows[1].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[1].Cells["NutrimentsValue"].Value) - (foundProduct.Fat * weight / 100), 2);
                nutriments_table.Rows[2].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[2].Cells["NutrimentsValue"].Value) - (foundProduct.Carbohydrates * weight / 100), 2);
                nutriments_table.Rows[3].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[3].Cells["NutrimentsValue"].Value) - (foundProduct.Fiber * weight / 100), 2);
                nutriments_table.Rows[4].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[4].Cells["NutrimentsValue"].Value) - (foundProduct.Protein * weight / 100), 2);
                nutriments_table.Rows[5].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[5].Cells["NutrimentsValue"].Value) - (foundProduct.Salt * weight / 100), 2);


                // 2. Usuń wiersz z product_table
                product_table.Rows.RemoveAt(e.RowIndex);

                // 3. Usuń produkt i wagę z list
                var productToRemove = productList.FirstOrDefault(p => p.Nazwa == productName);
                if (productToRemove != null)
                {
                    productList.Remove(productToRemove);
                }

                // Usuń wagę z listy wag
                if (weightList.Contains(weight))
                {
                    weightList.Remove(weight);
                }
            }
        }
        private void log_label_resize(object sender, EventArgs e)
        {
            int containerWidth = this.Width; // Zastąp to kontrolką, której szerokość ma być brana pod uwagę
            int labelWidth = log_label.Width;

            int newX = (containerWidth - labelWidth) / 2;
            log_label.Location = new Point(newX, log_label.Location.Y);
        }
    }
}
