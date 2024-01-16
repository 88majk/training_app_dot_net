namespace AplikacjaDotNetProjekt
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginChoose_button = new Button();
            newUser_button = new Button();
            login_label = new Label();
            textBox1 = new TextBox();
            login_button = new Button();
            return_button = new Button();
            log_label = new Label();
            SuspendLayout();
            // 
            // loginChoose_button
            // 
            loginChoose_button.Location = new Point(121, 21);
            loginChoose_button.Name = "loginChoose_button";
            loginChoose_button.Size = new Size(125, 53);
            loginChoose_button.TabIndex = 0;
            loginChoose_button.Text = "Login";
            loginChoose_button.UseVisualStyleBackColor = true;
            loginChoose_button.Click += loginChoose_button_Click;
            // 
            // newUser_button
            // 
            newUser_button.Location = new Point(121, 94);
            newUser_button.Name = "newUser_button";
            newUser_button.Size = new Size(125, 53);
            newUser_button.TabIndex = 1;
            newUser_button.Text = "New User";
            newUser_button.UseVisualStyleBackColor = true;
            newUser_button.Click += newUser_button_Click;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Location = new Point(139, 31);
            login_label.Name = "login_label";
            login_label.Size = new Size(89, 15);
            login_label.TabIndex = 2;
            login_label.Text = "Enter username";
            login_label.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            // 
            // login_button
            // 
            login_button.Location = new Point(44, 94);
            login_button.Name = "login_button";
            login_button.Size = new Size(125, 53);
            login_button.TabIndex = 4;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Visible = false;
            login_button.Click += login_button_Click;
            // 
            // return_button
            // 
            return_button.Location = new Point(189, 94);
            return_button.Name = "return_button";
            return_button.Size = new Size(125, 53);
            return_button.TabIndex = 5;
            return_button.Text = "Return";
            return_button.UseVisualStyleBackColor = true;
            return_button.Visible = false;
            return_button.Click += return_button_Click;
            // 
            // log_label
            // 
            log_label.AutoSize = true;
            log_label.ForeColor = Color.Red;
            log_label.Location = new Point(167, 159);
            log_label.Name = "log_label";
            log_label.Size = new Size(0, 15);
            log_label.TabIndex = 6;
            log_label.Resize += log_label_resize;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 184);
            Controls.Add(log_label);
            Controls.Add(return_button);
            Controls.Add(login_button);
            Controls.Add(textBox1);
            Controls.Add(login_label);
            Controls.Add(newUser_button);
            Controls.Add(loginChoose_button);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginChoose_button;
        private Button newUser_button;
        private Label login_label;
        private TextBox textBox1;
        private Button login_button;
        private Button return_button;
        private Label log_label;
    }
}