namespace AplikacjaDotNetProjekt
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addMeal_button = new Button();
            addTraining_button = new Button();
            user_label = new Label();
            logOut_button = new Button();
            addMeasurement_button = new Button();
            dateTimePicker1 = new DateTimePicker();
            tv = new TreeView();
            todaysExercises_listBox = new ListBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // addMeal_button
            // 
            addMeal_button.Location = new Point(53, 346);
            addMeal_button.Name = "addMeal_button";
            addMeal_button.Size = new Size(284, 32);
            addMeal_button.TabIndex = 2;
            addMeal_button.Text = "Add a meal";
            addMeal_button.UseVisualStyleBackColor = true;
            addMeal_button.Click += addMeal_button_Click;
            // 
            // addTraining_button
            // 
            addTraining_button.Location = new Point(415, 347);
            addTraining_button.Margin = new Padding(3, 4, 3, 4);
            addTraining_button.Name = "addTraining_button";
            addTraining_button.Size = new Size(322, 32);
            addTraining_button.TabIndex = 1;
            addTraining_button.Text = "Add training";
            addTraining_button.UseVisualStyleBackColor = true;
            addTraining_button.Click += addTraining_button_Click;
            // 
            // addMeal_button
            // 
            addMeal_button.Location = new Point(41, 142);
            addMeal_button.Name = "addMeal_button";
            addMeal_button.Size = new Size(86, 45);
            addMeal_button.TabIndex = 2;
            addMeal_button.Text = "Add a meal";
            addMeal_button.UseVisualStyleBackColor = true;
            addMeal_button.Click += addMeal_button_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(12, 9);
            user_label.Name = "user_label";
            user_label.Size = new Size(29, 15);
            user_label.TabIndex = 3;
            user_label.Text = "user";
            // 
            // logOut_button
            // 
            logOut_button.Location = new Point(12, 33);
            logOut_button.Margin = new Padding(3, 4, 3, 4);
            logOut_button.Name = "logOut_button";
            logOut_button.Size = new Size(73, 27);
            logOut_button.TabIndex = 4;
            logOut_button.Text = "Log Out";
            logOut_button.UseVisualStyleBackColor = true;
            logOut_button.Click += logOut_button_Click;
            // 
            // addMeasurement_button
            // 
            addMeasurement_button.Location = new Point(91, 33);
            addMeasurement_button.Name = "addMeasurement_button";
            addMeasurement_button.Size = new Size(140, 27);
            addMeasurement_button.TabIndex = 5;
            addMeasurement_button.Text = "Add measurement";
            addMeasurement_button.UseVisualStyleBackColor = true;
            addMeasurement_button.Click += addMeasurement_button_Click;
            //
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 1, 17, 13, 9, 49, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tv
            // 
            tv.Location = new Point(224, 189);
            tv.Name = "tv";
            tv.Size = new Size(284, 225);
            tv.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(240, 82);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 1, 20, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tv
            // 
            tv.BackColor = SystemColors.ControlLightLight;
            tv.LineColor = Color.DimGray;
            tv.Location = new Point(53, 115);
            tv.Name = "tv";
            tv.Size = new Size(284, 225);
            tv.TabIndex = 6;
            // 
            // todaysExercises_listBox
            // 
            todaysExercises_listBox.FormattingEnabled = true;
            todaysExercises_listBox.ItemHeight = 20;
            todaysExercises_listBox.Location = new Point(415, 116);
            todaysExercises_listBox.Name = "todaysExercises_listBox";
            todaysExercises_listBox.Size = new Size(322, 224);
            todaysExercises_listBox.TabIndex = 7;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(todaysExercises_listBox);
            Controls.Add(tv);
            Controls.Add(dateTimePicker1);
            Controls.Add(addMeasurement_button);
            Controls.Add(logOut_button);
            Controls.Add(user_label);
            Controls.Add(addMeal_button);
            Controls.Add(addTraining_button);
            Margin = new Padding(3, 4, 3, 4);

            Name = "HomePage";
            Text = "Home Page";
            FormClosed += HomePage_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addTraining_button;
        private Button addMeal_button;
        private Label user_label;
        private Button logOut_button;
        private Button addMeasurement_button;
        private DateTimePicker dateTimePicker1;
        private TreeView tv;
        private ListBox todaysExercises_listBox;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}