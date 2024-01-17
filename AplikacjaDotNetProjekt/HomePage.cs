using AplikacjaDotNetProjekt.Database;
using AplikacjaDotNetProjekt.Database.Models;

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
        List<string> typeMealList = new List<string>() { "Breakfast", "Brunch", "Dinner", "Dessert", "Lunch", "Supper", "Snack" };

        public HomePage(Login login)
        {
            user = login.LoggedInUser;
            InitializeComponent();
            user_label.Text = "Username: " + user.Name;
            _login = login;
            _userMeal = new Database.Services.UserMealService(new DBContext());
            _meal = new Database.Services.MealService(new DBContext());
            InitializeTreeView();

        }

        public bool getIsLogOut
        {
            get { return isLogOut; }
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            if (addMeal == null || addMeal.IsDisposed)
            {
                DateTime selectedDate = dateTimePicker1.Value;
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
        }

        private void InitializeTreeView()
        {
            if (addMeal != null)
            {
                addMeal.Close();

            }
            DateTime currentDate = dateTimePicker1.Value.Date;
            List<UserMeal> allMealsToday = _userMeal.GetUserMealsForDate(currentDate, user.Id);
            if (tv.Nodes.Count > 0)
            {
                tv.Nodes.Clear();
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
                    }
                }
            }
        }
        private void addTraining_button_Click(object sender, EventArgs e)
        {
            if (addTraining == null || addTraining.IsDisposed)
            {
                addTraining = new AddTraining();
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
        private void addTraining_button_Click(object sender, EventArgs e)
        {
            if (addTraining == null || addTraining.IsDisposed)
            {
                addTraining = new AddTraining(user.Id);
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