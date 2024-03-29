using AplikacjaDotNetProjekt.Database;
using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace AplikacjaDotNetProjekt
{
    public partial class HomePage : Form
    {
        AddMeal addMeal;
        User user;
        Login _login;
        AddTraining addTraining;
        AddMeasurement addMeasurement;
        private bool isLogOut = false;
        private Database.Services.UserMealService _userMeal;
        private Database.Services.MealService _meal;
        private Database.Services.RecipeService _recipe;
        private Database.Services.ProductService _product;
        private Database.Services.TrainingService _trainingService;
        private Database.Services.ExercisesInTrainingService _EITService;
        private DBContext _dbContext;

        List<string> typeMealList = new List<string>() { "Breakfast", "Brunch", "Dinner", "Dessert", "Lunch", "Supper", "Snack" };

        public HomePage(Login login)
        {
            user = login.LoggedInUser;
            InitializeComponent();
            user_label.Text = "Username: " + user.Name;
            _login = login;
            _userMeal = new Database.Services.UserMealService(new DBContext());
            _meal = new Database.Services.MealService(new DBContext());
            _recipe = new Database.Services.RecipeService(new DBContext());
            _product = new Database.Services.ProductService(new DBContext());
            _trainingService = new Database.Services.TrainingService(new DBContext());
            _EITService = new Database.Services.ExercisesInTrainingService(new DBContext());
            _dbContext = new DBContext();
            InitializeTreeView();
            InitializeTodaysExercises();
        }

        public bool getIsLogOut
        {
            get { return isLogOut; }
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            if (addMeal == null || addMeal.IsDisposed)
            {
                DateTime selectedDate = dateChoose_dateClicker.Value;
                addMeal = new AddMeal(user, selectedDate, this);
                addMeal.Show();

            }
            else
            {
                if (addMeal.WindowState == FormWindowState.Minimized)
                {
                    addMeal.WindowState = FormWindowState.Normal;
                }

                addMeal.BringToFront();
                addMeal.Focus();
            }
        }

        private void logOut_button_Click(object sender, EventArgs e)
        {
            _login.resetLoginForm(true);
            _login.Show();
            this.Close();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _login.CloseIfNotLoggedOut();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            InitializeTreeView();
            InitializeTodaysExercises();
        }

        private void InitializeTreeView()
        {
            if (addMeal != null)
            {
                addMeal.Close();
            }
            DateTime currentDate = dateChoose_dateClicker.Value.Date;
            List<UserMeal> allMealsToday = _userMeal.GetUserMealsForDate(currentDate, user.Id);
            if (tv.Nodes.Count > 0)
            {
                tv.Nodes.Clear();
            }
            if (nutriments_table.RowCount > 0)
            {
                nutriments_table.Rows.Clear();
            }
            foreach (string type in typeMealList)
            {
                TreeNode node = new TreeNode(type);
                tv.Nodes.Add(node);

            }
            foreach (UserMeal userMeal in allMealsToday)
            {
                updateVievMealToday(currentDate, userMeal);
            }
        }

        public void InitializeTodaysExercises()
        {
            DateTime currentDate = dateChoose_dateClicker.Value.Date;
            List<Training> todayTraining = _trainingService.GetTodaysTraining(user.Id, currentDate);

            todaysExercises_listBox.Items.Clear();
            int i = 0;
            foreach (Training training in todayTraining)
            {
                int todayTrainingId = _trainingService.GetTrainingIdByName(training.Name);
                List<ExercisesInTraining> todayExercises = _EITService.GetAllExercisesInTraining(todayTrainingId);

                List<ExercisesInTrainingDisplay> displayList =
                    todayExercises.Select(exercise => new ExercisesInTrainingDisplay
                    {
                        ExerciseName = _dbContext.CatalogExercises.FirstOrDefault(c => c.Id == exercise.ExerciseId)?.Name,
                        Sets = exercise.Sets,
                        Reps = exercise.Reps,
                        Weight = exercise.Weight
                    })
                .ToList();

                foreach (var item in displayList)
                {
                    i++;
                    todaysExercises_listBox.Items.Add(i + ". " + item.ToString());
                }
            }
        }

        public void updateVievMealToday(DateTime date, UserMeal userMeal)
        {
            foreach (TreeNode node in tv.Nodes)
            {
                if (node.Text == userMeal.MealType)
                {
                    Meal meal = _meal.GetMealByIdWith(userMeal.MealId);
                    if (meal != null)
                    {
                        TreeNode mealNode = new TreeNode(meal.Name);
                        node.Nodes.Add(mealNode);
                        List<Recipe> recipes = _recipe.GetRecipeByMealId(meal.Id);
                        if (recipes != null)
                        {
                            foreach (Recipe recipe in recipes)
                            {
                                Product product = _product.GetProductById(recipe.ProductId);
                                if (nutriments_table.RowCount < 1)
                                {
                                    // To pierwszy produkt, dodaj nutriments do tabeli nutriments_table
                                    nutriments_table.Rows.Add(product.EnergyKcal * recipe.Weight / 100,
                                        product.Fat * recipe.Weight / 100,
                                        product.Carbohydrates * recipe.Weight / 100,
                                        product.Fiber * recipe.Weight / 100,
                                        product.Protein * recipe.Weight / 100,
                                        product.Salt * recipe.Weight / 100);
                                }
                                else
                                {
                                    nutriments_table.Rows[0].Cells["Kcal"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["Kcal"].Value) + (product.EnergyKcal * recipe.Weight / 100), 2);
                                    nutriments_table.Rows[0].Cells["Fat"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["Fat"].Value) + (product.Fat * recipe.Weight / 100), 2);
                                    nutriments_table.Rows[0].Cells["Carbohydrates"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["Carbohydrates"].Value) + (product.Carbohydrates * recipe.Weight / 100), 2);
                                    nutriments_table.Rows[0].Cells["Fiber"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["Fiber"].Value) + (product.Fiber * recipe.Weight / 100), 2);
                                    nutriments_table.Rows[0].Cells["Protein"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["Protein"].Value) + (product.Protein * recipe.Weight / 100), 2);
                                    nutriments_table.Rows[0].Cells["Salt"].Value = (float)Math.Round(Convert.ToSingle(nutriments_table.Rows[0].Cells["Salt"].Value) + (product.Salt * recipe.Weight / 100), 2);


                                }
                            }
                        }
                    }
                }
            }
        }
        private void addTraining_button_Click(object sender, EventArgs e)
        {
            if (addTraining == null || addTraining.IsDisposed)
            {

                DateTime selectedDate = dateChoose_dateClicker.Value;
                addTraining = new AddTraining(this, selectedDate, user.Id);
                addTraining.Show();
            }
            else
            {
                if (addTraining.WindowState == FormWindowState.Minimized)
                {
                    addTraining.WindowState = FormWindowState.Normal;
                }

                addTraining.BringToFront();
                addTraining.Focus();

            }
        }

        private void addMeasurement_button_Click(object sender, EventArgs e)
        {
            if (addMeasurement == null || addMeasurement.IsDisposed)
            {
                addMeasurement = new AddMeasurement(user.Id);
                addMeasurement.Show();
            }
            else
            {
                if (addMeasurement.WindowState == FormWindowState.Minimized)
                {
                    addMeasurement.WindowState = FormWindowState.Normal;
                }

                addMeasurement.BringToFront();
                addMeasurement.Focus();
            }
        }
    }
}