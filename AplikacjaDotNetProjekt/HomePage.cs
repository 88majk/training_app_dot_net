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

        public HomePage(Login login)
        {
            user = login.LoggedInUser;
            InitializeComponent();
            user_label.Text = "Username: " + user.Name;
            _login = login;

        }

        public bool getIsLogOut
        {
            get { return isLogOut; }
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            if (addMeal == null || addMeal.IsDisposed)
            {
                addMeal = new AddMeal();
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
}