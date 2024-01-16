using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaDotNetProjekt.Database;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AplikacjaDotNetProjekt
{
    public partial class Login : Form
    {
        private Database.Services.UserService _userService;
        private Database.Models.User _loggedInUser;
        private bool CloseAfterLogout { get; set; } = false;
        public Login()
        {
            InitializeComponent();
            _userService = new Database.Services.UserService(new DBContext());

        }

        public Database.Models.User LoggedInUser
        {
            get { return _loggedInUser; }
        }

        private void loginChoose_button_Click(object sender, EventArgs e)
        {
            loginChoose_button.Visible = false;
            newUser_button.Visible = false;
            log_label.Text = "";
            textBox1.Text = "";

            login_label.Visible = true;
            textBox1.Visible = true;
            login_button.Text = "Login";
            login_button.Visible = true;
            return_button.Visible = true;
        }

        private void newUser_button_Click(object sender, EventArgs e)
        {
            loginChoose_button.Visible = false;
            newUser_button.Visible = false;
            log_label.Text = "";
            textBox1.Text = "";

            login_label.Visible = true;
            textBox1.Visible = true;
            login_button.Text = "Add user";
            login_button.Visible = true;
            return_button.Visible = true;

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            loginChoose_button.Visible = true;
            newUser_button.Visible = true;
            log_label.Text = "";
            textBox1.Text = "";

            login_label.Visible = false;
            textBox1.Visible = false;
            login_button.Visible = false;
            return_button.Visible = false;

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            CloseAfterLogout = false;
            if (login_button.Text == "Login")
            {
                string username = textBox1.Text.Trim();
                Database.Models.User user = _userService.GetUserByName(username);
                if (user != null)
                {
                    _loggedInUser = user;
                    HomePage homePage = new HomePage(this);
                    homePage.Show();

                    this.Hide();
                }
                else
                {
                    log_label.Text = "Error: no such user exists";
                }
            }
            else
            {
                string username = textBox1.Text.Trim();
                int userId = _userService.AddUserToDatabase(username);
                if (userId == -1)
                {
                    log_label.Text = "Error: failed to add user";
                }
                else if (userId == -2)
                {
                    log_label.Text = "Error: Such a user already exists";
                }
                else
                {
                    log_label.Text = "User added, you can log in";
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
        public void resetLoginForm(bool afterLogout)
        {
            loginChoose_button.Visible = true;
            newUser_button.Visible = true;
            log_label.Text = "";
            textBox1.Text = "";

            login_label.Visible = false;
            textBox1.Visible = false;
            login_button.Visible = false;
            return_button.Visible = false;
            if (afterLogout)
            {
                this.CloseAfterLogout = true;
            }

        }
        public void CloseIfNotLoggedOut()
        {
            if (!this.CloseAfterLogout)
            {
                this.Close();
            }
        }
    }
}
