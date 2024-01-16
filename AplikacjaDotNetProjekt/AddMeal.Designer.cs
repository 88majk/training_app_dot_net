namespace AplikacjaDotNetProjekt
{
    partial class AddMeal
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
            addProduct_button = new Button();
            addMeal_button = new Button();
            mealEnter_textBox = new TextBox();
            mealEnter_label = new Label();
            log_label = new Label();
            mealType_combobox = new ComboBox();
            mealType_label = new Label();
            product_table = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            ProductWeight = new DataGridViewTextBoxColumn();
            nutriments_table = new DataGridView();
            NutrimentsName = new DataGridViewTextBoxColumn();
            NutrimentsValue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)product_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nutriments_table).BeginInit();
            SuspendLayout();
            // 
            // addProduct_button
            // 
            addProduct_button.Location = new Point(157, 340);
            addProduct_button.Name = "addProduct_button";
            addProduct_button.Size = new Size(95, 42);
            addProduct_button.TabIndex = 0;
            addProduct_button.Text = "Add product";
            addProduct_button.UseVisualStyleBackColor = true;
            addProduct_button.Click += addProduct_button_Click;
            // 
            // addMeal_button
            // 
            addMeal_button.Location = new Point(266, 340);
            addMeal_button.Name = "addMeal_button";
            addMeal_button.Size = new Size(95, 42);
            addMeal_button.TabIndex = 2;
            addMeal_button.Text = "Add meal";
            addMeal_button.UseVisualStyleBackColor = true;
            addMeal_button.Click += addMeal_button_Click;
            // 
            // mealEnter_textBox
            // 
            mealEnter_textBox.Location = new Point(266, 280);
            mealEnter_textBox.Name = "mealEnter_textBox";
            mealEnter_textBox.Size = new Size(142, 23);
            mealEnter_textBox.TabIndex = 4;
            // 
            // mealEnter_label
            // 
            mealEnter_label.AutoSize = true;
            mealEnter_label.Location = new Point(102, 288);
            mealEnter_label.Name = "mealEnter_label";
            mealEnter_label.Size = new Size(150, 15);
            mealEnter_label.TabIndex = 5;
            mealEnter_label.Text = "Enter the name of the meal";
            // 
            // log_label
            // 
            log_label.AutoSize = true;
            log_label.ForeColor = Color.Red;
            log_label.Location = new Point(234, 410);
            log_label.Name = "log_label";
            log_label.Size = new Size(0, 15);
            log_label.TabIndex = 6;
            log_label.Resize += log_label_resize;
            // 
            // mealType_combobox
            // 
            mealType_combobox.FormattingEnabled = true;
            mealType_combobox.Location = new Point(266, 309);
            mealType_combobox.Name = "mealType_combobox";
            mealType_combobox.Size = new Size(142, 23);
            mealType_combobox.TabIndex = 7;
            // 
            // mealType_label
            // 
            mealType_label.AutoSize = true;
            mealType_label.Location = new Point(102, 317);
            mealType_label.Name = "mealType_label";
            mealType_label.Size = new Size(93, 15);
            mealType_label.TabIndex = 8;
            mealType_label.Text = "Select meal type";
            // 
            // product_table
            // 
            product_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            product_table.Columns.AddRange(new DataGridViewColumn[] { ProductName, ProductWeight });
            product_table.Location = new Point(12, 31);
            product_table.Name = "product_table";
            product_table.RowTemplate.Height = 25;
            product_table.Size = new Size(240, 230);
            product_table.TabIndex = 9;
            product_table.CellDoubleClick += product_table_CellDoubleClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product name";
            ProductName.Name = "ProductName";
            // 
            // ProductWeight
            // 
            ProductWeight.HeaderText = "Weight";
            ProductWeight.Name = "ProductWeight";
            // 
            // nutriments_table
            // 
            nutriments_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nutriments_table.Columns.AddRange(new DataGridViewColumn[] { NutrimentsName, NutrimentsValue });
            nutriments_table.Location = new Point(266, 31);
            nutriments_table.Name = "nutriments_table";
            nutriments_table.RowTemplate.Height = 25;
            nutriments_table.Size = new Size(240, 230);
            nutriments_table.TabIndex = 10;
            // 
            // NutrimentsName
            // 
            NutrimentsName.HeaderText = "Nutriments";
            NutrimentsName.Name = "NutrimentsName";
            // 
            // NutrimentsValue
            // 
            NutrimentsValue.HeaderText = "Value";
            NutrimentsValue.Name = "NutrimentsValue";
            // 
            // AddMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 463);
            Controls.Add(nutriments_table);
            Controls.Add(product_table);
            Controls.Add(mealType_label);
            Controls.Add(mealType_combobox);
            Controls.Add(log_label);
            Controls.Add(mealEnter_label);
            Controls.Add(mealEnter_textBox);
            Controls.Add(addMeal_button);
            Controls.Add(addProduct_button);
            Name = "AddMeal";
            Text = "AddMeal";
            ((System.ComponentModel.ISupportInitialize)product_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)nutriments_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProduct_button;
        private Button addMeal_button;
        private TextBox mealEnter_textBox;
        private Label mealEnter_label;
        private Label log_label;
        private ComboBox mealType_combobox;
        private Label mealType_label;
        private DataGridView product_table;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductWeight;
        private DataGridView nutriments_table;
        private DataGridViewTextBoxColumn NutrimentsName;
        private DataGridViewTextBoxColumn NutrimentsValue;
    }
}