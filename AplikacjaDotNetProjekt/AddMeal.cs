using AddProductLibrary;
using AplikacjaDotNetProjekt.Database.Models;
using AplikacjaDotNetProjekt.Database.Services;
using AplikacjaDotNetProjekt.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AplikacjaDotNetProjekt
{
    public partial class AddMeal : Form
    {
        AddProduct addProduct;
        User user;
        
        List<Product> productList;
        List<float> weightList;
        private Database.Services.MealService _mealService;
        List<string> typeMealList = new List<string>() { "Breakfast", "Brunch", "Dinner", "Dessert", "Lunch", "Supper", "Snack" };
        private Database.Services.ProductService productService = new Database.Services.ProductService(new DBContext());
        private Database.Services.UserMealService _userMealService;
        private Database.Services.RecipeService _recipeService;
        public List<Meal> mealList = new List<Meal>();
        private bool preventSelectMealEvent = false;
        DateTime date;
        private HomePage homePage;


        private void AddMeal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addProduct != null && !addProduct.IsDisposed)
            {
                addProduct.Close();
            }
        }
        public AddMeal(User LogInUser, DateTime selectedDate, HomePage homePage)
        {
            InitializeComponent();
            user = LogInUser;
            productList = new List<Product>();
            weightList = new List<float>();
            this.FormClosing += AddMeal_FormClosing;
            date = selectedDate;
            homePage = homePage;

            mealType_combobox.Items.AddRange(typeMealList.ToArray());
            _mealService = new Database.Services.MealService(new DBContext());
            _userMealService = new Database.Services.UserMealService(new DBContext());
            _recipeService = new Database.Services.RecipeService(new DBContext());

            ClearPage();

            newMealChoose_button.Visible = true;
            myMealChoose_button.Visible = true;
            allMealChoose_button.Visible = true;
            this.homePage = homePage;

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
                }
                Meal mealOld = _mealService.GetMealByName(mealName);
                int mealId;
                if (mealOld == null)
                {
                    mealId = _mealService.AddMealToDatabase(meal, productList, weightList);
                }
                else
                {
                    List<Recipe> recipes = _recipeService.GetRecipeByMealId(mealOld.Id);
                    bool sameProducts = true;
                    
                    foreach (Product product in productList)
                    {
                        for (int i = 0; i < productList.Count; i++)
                        {
                            int recipeIndex = recipes.FindIndex(recipe => recipe.ProductId == productList[i].Id);
                            if (recipeIndex != -1)
                            {
                                if (recipes[recipeIndex].Weight != weightList[i])
                                {
                                    sameProducts = false;
                                    break;
                                }

                            }
                            else
                            {
                                sameProducts = true;
                                break;
                            }
                        }
                    }
                    if (sameProducts == true)
                    {
                        mealId = mealOld.Id;

                    }
                    else
                    {

                        string lastMealname = _mealService.GetLastMealNameFromDatabase(mealName);
                        int suffix = 1;
                        if (!string.IsNullOrEmpty(lastMealname) && lastMealname.Contains("_"))
                        {
                            string[] parts = lastMealname.Split('_');
                            int lastSuffix;

                            if (int.TryParse(parts[1], out lastSuffix))
                            {
                                suffix = lastSuffix + 1;
                            }
                        }
                        string uniqueMealName = $"{mealName}_{suffix}";
                        meal.Name = uniqueMealName;
                        mealId = _mealService.AddMealToDatabase(meal, productList, weightList);
                    }
                }
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

                int userMealId = _userMealService.AddUserMeal(user.Id, mealId, mealType, date.Date);
                if (userMealId == -1)
                {
                    log_label.Visible = true;
                    log_label.Text = $"Error: the meal has not been added";
                    return;
                }
                else
                {
                    log_label.Visible = true;
                    log_label.Text = $"the meal was added with id = {mealId}";
                    if (addProduct != null && !addProduct.IsDisposed)
                    {
                        addProduct.Close();
                    }
                    UserMeal usermeal = _userMealService.GetUserMealsById(userMealId);
                    homePage.updateVievMealToday(date.Date, usermeal);
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
            DeleteIndexFromProductTable(e.RowIndex);
        }

        private void log_label_resize(object sender, EventArgs e)
        {
            int containerWidth = this.Width; // Zastąp to kontrolką, której szerokość ma być brana pod uwagę
            int labelWidth = log_label.Width;

            int newX = (containerWidth - labelWidth) / 2;
            log_label.Location = new Point(newX, log_label.Location.Y);
        }

        private void ClearPage()
        {
            // choose button
            newMealChoose_button.Visible = false;
            myMealChoose_button.Visible = false;
            allMealChoose_button.Visible = false;

            // new meal
            nutriments_table.Visible = false;
            product_table.Visible = false;
            mealEnter_label.Visible = false;
            mealEnter_textBox.Visible = false;
            mealType_label.Visible = false;
            mealType_combobox.Visible = false;
            addMeal_button.Visible = false;
            addProduct_button.Visible = false;
            return_button.Visible = false;

            // my meal
            selectMeal_comboBox.Visible = false;
            selectMeal_label.Visible = false;
            return_button_2.Visible = false;
        }

        private void newMealChoose_button_Click(object sender, EventArgs e)
        {
            ClearPage();

            productList.Clear();
            weightList.Clear();

            nutriments_table.Visible = true;
            product_table.Visible = true;
            nutriments_table.Rows.Clear();
            nutriments_table.Refresh();
            product_table.Rows.Clear();
            product_table.Refresh();
            mealEnter_label.Visible = true;
            mealEnter_textBox.Visible = true;
            mealType_label.Visible = true;
            mealType_combobox.Visible = true;
            addMeal_button.Visible = true;
            addProduct_button.Visible = true;
            return_button.Visible = true;
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            ClearPage();

            newMealChoose_button.Visible = true;
            myMealChoose_button.Visible = true;
            allMealChoose_button.Visible = true;
        }

        private void product_table_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                product_table.CurrentCell = product_table.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenuStrip contextMenu = new ContextMenuStrip();

                // Dodaj opcję "Edytuj"
                ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Edytuj");
                editMenuItem.Click += EditMenuItem_Click;
                contextMenu.Items.Add(editMenuItem);

                // Dodaj opcję "Usuń"
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Usuń");
                deleteMenuItem.Click += DeleteMenuItem_Click;
                contextMenu.Items.Add(deleteMenuItem);

                contextMenu.Show(product_table, product_table.PointToClient(Cursor.Position));
            }
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = product_table.CurrentCell.RowIndex;

            // Sprawdź, czy wiersz i kolumna są prawidłowe
            if (selectedRowIndex < 0 || selectedRowIndex >= product_table.Rows.Count)
            {
                return;
            }

            // Ustaw odpowiednią komórkę na tryb edycji
            DataGridViewCell cellToEdit = product_table.Rows[selectedRowIndex].Cells["ProductWeight"];
            product_table.CurrentCell = cellToEdit;
            product_table.BeginEdit(true);

            product_table.CellEndEdit += Product_table_CellEndEdit;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = product_table.CurrentCell.RowIndex;
            DeleteIndexFromProductTable(selectedRowIndex);
        }

        private void DeleteIndexFromProductTable(int index)
        {
            if (index >= 0)
            {
                // Pobierz dane zaznaczonego wiersza
                string productName = product_table.Rows[index].Cells["ProductName"].Value.ToString();
                float weight = Convert.ToSingle(product_table.Rows[index].Cells["ProductWeight"].Value);
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
                product_table.Rows.RemoveAt(index);


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
        private void Product_table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int changedRowIndex = e.RowIndex;
            float newWeight = Convert.ToSingle(product_table.Rows[changedRowIndex].Cells["ProductWeight"].Value);
            float oldWeight = weightList[changedRowIndex];
            Product product = productList[changedRowIndex];

            weightList[changedRowIndex] = newWeight;

            nutriments_table.Rows[0].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["NutrimentsValue"].Value) - (product.EnergyKcal * oldWeight / 100), 2);
            nutriments_table.Rows[1].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[1].Cells["NutrimentsValue"].Value) - (product.Fat * oldWeight / 100), 2);
            nutriments_table.Rows[2].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[2].Cells["NutrimentsValue"].Value) - (product.Carbohydrates * oldWeight / 100), 2);
            nutriments_table.Rows[3].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[3].Cells["NutrimentsValue"].Value) - (product.Fiber * oldWeight / 100), 2);
            nutriments_table.Rows[4].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[4].Cells["NutrimentsValue"].Value) - (product.Protein * oldWeight / 100), 2);
            nutriments_table.Rows[5].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[5].Cells["NutrimentsValue"].Value) - (product.Salt * oldWeight / 100), 2);

            nutriments_table.Rows[0].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["NutrimentsValue"].Value) + (product.EnergyKcal * newWeight / 100), 2);
            nutriments_table.Rows[1].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[1].Cells["NutrimentsValue"].Value) + (product.Fat * newWeight / 100), 2);
            nutriments_table.Rows[2].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[2].Cells["NutrimentsValue"].Value) + (product.Carbohydrates * newWeight / 100), 2);
            nutriments_table.Rows[3].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[3].Cells["NutrimentsValue"].Value) + (product.Fiber * newWeight / 100), 2);
            nutriments_table.Rows[4].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[4].Cells["NutrimentsValue"].Value) + (product.Protein * newWeight / 100), 2);
            nutriments_table.Rows[5].Cells["NutrimentsValue"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[5].Cells["NutrimentsValue"].Value) + (product.Salt * newWeight / 100), 2);
        }

        private void myMealChoose_button_Click(object sender, EventArgs e)
        {
            ClearPage();

            weightList.Clear();
            productList.Clear();
            mealList.Clear();

            selectMeal_comboBox.DataSource = null;
            selectMeal_comboBox.Items.Clear();

            nutriments_table.Rows.Clear();
            nutriments_table.Refresh();
            product_table.Rows.Clear();
            product_table.Refresh();

            selectMeal_label.Visible = true;
            selectMeal_comboBox.Visible = true;
            return_button_2.Visible = true;

            // dodać wyszukanie produktów w bazie dla tego użytkownika co aktualnie

            List<UserMeal> userMealList = _userMealService.GetUserMealsForUser(user.Id);
            foreach (UserMeal usermeal in userMealList)
            {
                Meal meal = _mealService.GetMealById(usermeal.Id);
                if (meal != null)
                {
                    mealList.Add(meal);
                }
            }
            preventSelectMealEvent = true;
            selectMeal_comboBox.DataSource = mealList.Select(m => m.Name).ToList();
            preventSelectMealEvent = false;
        }

        private void allMealChoose_button_Click(object sender, EventArgs e)
        {
            ClearPage();

            weightList.Clear();
            productList.Clear();

            selectMeal_comboBox.DataSource = null;
            selectMeal_comboBox.Items.Clear();
            mealList.Clear();

            nutriments_table.Rows.Clear();
            nutriments_table.Refresh();
            product_table.Rows.Clear();
            product_table.Refresh();

            selectMeal_label.Visible = true;
            selectMeal_comboBox.Visible = true;
            return_button_2.Visible = true;

            // dodać wyszukanie produktów w bazie dla wszystkich użytkowników
            // wypisać produkty i kalorykę
            // dodać je de list

            List<UserMeal> userMealList = _userMealService.GetAllUserMeals();
            foreach (UserMeal usermeal in userMealList)
            {
                Meal meal = _mealService.GetMealById(usermeal.Id);
                if (meal != null)
                {
                    mealList.Add(meal);
                }
            }

            preventSelectMealEvent = true;
            selectMeal_comboBox.DataSource = mealList.Select(m => m.Name).ToList();
            preventSelectMealEvent = false;

        }

        private void selectMeal_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!preventSelectMealEvent && selectMeal_comboBox.SelectedItem != null)
            {
                weightList.Clear();
                productList.Clear();

                int selectedIndex = selectMeal_comboBox.SelectedIndex;
                int mealId = mealList[selectedIndex].Id;
                List<Recipe> recipes = _recipeService.GetRecipeByMealId(mealId);
                List<Product> products = new List<Product>();
                foreach (Recipe recipe in recipes)
                {
                    products.Add(productService.GetProductById(recipe.ProductId));
                }

                for (int i = 0; i < products.Count; i++)
                {
                    AddProductToList(recipes[i].Weight, products[i]);
                }
                ClearPage();

                nutriments_table.Visible = true;
                product_table.Visible = true;
                mealEnter_label.Visible = true;
                mealEnter_textBox.Visible = true;
                mealType_label.Visible = true;
                mealType_combobox.Visible = true;
                addMeal_button.Visible = true;
                addProduct_button.Visible = true;
                return_button.Visible = true;
            }
        }
    }
}
