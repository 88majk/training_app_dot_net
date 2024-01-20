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
            dateChoose_dateClicker = new DateTimePicker();
            tv = new TreeView();
            todaysExercises_listBox = new ListBox();
            nutriments_table = new DataGridView();
            Kcal = new DataGridViewTextBoxColumn();
            Fat = new DataGridViewTextBoxColumn();
            Carbohydrates = new DataGridViewTextBoxColumn();
            Fiber = new DataGridViewTextBoxColumn();
            Protein = new DataGridViewTextBoxColumn();
            Salt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nutriments_table).BeginInit();
            SuspendLayout();
            // 
            // addMeal_button
            // 
            addMeal_button.Location = new Point(13, 260);
            addMeal_button.Margin = new Padding(3, 2, 3, 2);
            addMeal_button.Name = "addMeal_button";
            addMeal_button.Size = new Size(313, 24);
            addMeal_button.TabIndex = 2;
            addMeal_button.Text = "Add a meal";
            addMeal_button.UseVisualStyleBackColor = true;
            addMeal_button.Click += addMeal_button_Click;
            // 
            // addTraining_button
            // 
            addTraining_button.Location = new Point(374, 260);
            addTraining_button.Name = "addTraining_button";
            addTraining_button.Size = new Size(314, 24);
            addTraining_button.TabIndex = 1;
            addTraining_button.Text = "Add training";
            addTraining_button.UseVisualStyleBackColor = true;
            addTraining_button.Click += addTraining_button_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_label.ForeColor = Color.OrangeRed;
            user_label.Location = new Point(12, 1);
            user_label.Name = "user_label";
            user_label.Size = new Size(40, 21);
            user_label.TabIndex = 3;
            user_label.Text = "user";
            // 
            // logOut_button
            // 
            logOut_button.Location = new Point(10, 25);
            logOut_button.Name = "logOut_button";
            logOut_button.Size = new Size(64, 26);
            logOut_button.TabIndex = 4;
            logOut_button.Text = "Log Out";
            logOut_button.UseVisualStyleBackColor = true;
            logOut_button.Click += logOut_button_Click;
            // 
            // addMeasurement_button
            // 
            addMeasurement_button.Location = new Point(80, 25);
            addMeasurement_button.Margin = new Padding(3, 2, 3, 2);
            addMeasurement_button.Name = "addMeasurement_button";
            addMeasurement_button.Size = new Size(122, 26);
            addMeasurement_button.TabIndex = 5;
            addMeasurement_button.Text = "Add measurement";
            addMeasurement_button.UseVisualStyleBackColor = true;
            addMeasurement_button.Click += addMeasurement_button_Click;
            // 
            // dateChoose_dateClicker
            // 
            dateChoose_dateClicker.Location = new Point(210, 62);
            dateChoose_dateClicker.Margin = new Padding(3, 2, 3, 2);
            dateChoose_dateClicker.Name = "dateChoose_dateClicker";
            dateChoose_dateClicker.Size = new Size(249, 23);
            dateChoose_dateClicker.TabIndex = 5;
            dateChoose_dateClicker.Value = new DateTime(2024, 1, 17, 13, 9, 49, 0);
            dateChoose_dateClicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tv
            // 
            tv.Location = new Point(13, 89);
            tv.Margin = new Padding(3, 2, 3, 2);
            tv.Name = "tv";
            tv.Size = new Size(313, 170);
            tv.TabIndex = 6;
            // 
            // todaysExercises_listBox
            // 
            todaysExercises_listBox.FormattingEnabled = true;
            todaysExercises_listBox.ItemHeight = 15;
            todaysExercises_listBox.Location = new Point(374, 89);
            todaysExercises_listBox.Margin = new Padding(3, 2, 3, 2);
            todaysExercises_listBox.Name = "todaysExercises_listBox";
            todaysExercises_listBox.Size = new Size(314, 169);
            todaysExercises_listBox.TabIndex = 7;
            // 
            // nutriments_table
            // 
            nutriments_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nutriments_table.Columns.AddRange(new DataGridViewColumn[] { Kcal, Fat, Carbohydrates, Fiber, Protein, Salt });
            nutriments_table.Location = new Point(10, 311);
            nutriments_table.Name = "nutriments_table";
            nutriments_table.RowHeadersWidth = 25;
            nutriments_table.RowTemplate.Height = 25;
            nutriments_table.Size = new Size(678, 65);
            nutriments_table.TabIndex = 8;
            // 
            // Kcal
            // 
            Kcal.HeaderText = "Kcal";
            Kcal.Name = "Kcal";
            // 
            // Fat
            // 
            Fat.HeaderText = "Fat";
            Fat.Name = "Fat";
            // 
            // Carbohydrates
            // 
            Carbohydrates.HeaderText = "Carbohydrates";
            Carbohydrates.Name = "Carbohydrates";
            // 
            // Fiber
            // 
            Fiber.HeaderText = "Fiber";
            Fiber.Name = "Fiber";
            // 
            // Protein
            // 
            Protein.HeaderText = "Protein";
            Protein.Name = "Protein";
            // 
            // Salt
            // 
            Salt.HeaderText = "Salt";
            Salt.Name = "Salt";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 388);
            Controls.Add(nutriments_table);
            Controls.Add(todaysExercises_listBox);
            Controls.Add(tv);
            Controls.Add(dateChoose_dateClicker);
            Controls.Add(addMeasurement_button);
            Controls.Add(logOut_button);
            Controls.Add(user_label);
            Controls.Add(addMeal_button);
            Controls.Add(addTraining_button);
            Name = "HomePage";
            Text = "Home Page";
            FormClosed += HomePage_FormClosed;
            ((System.ComponentModel.ISupportInitialize)nutriments_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addTraining_button;
        private Button addMeal_button;
        private Label user_label;
        private Button logOut_button;
        private Button addMeasurement_button;
        private DateTimePicker dateChoose_dateClicker;
        private TreeView tv;
        private ListBox todaysExercises_listBox;
        private DataGridView nutriments_table;
        private DataGridViewTextBoxColumn Kcal;
        private DataGridViewTextBoxColumn Fat;
        private DataGridViewTextBoxColumn Carbohydrates;
        private DataGridViewTextBoxColumn Fiber;
        private DataGridViewTextBoxColumn Protein;
        private DataGridViewTextBoxColumn Salt;
    }
}