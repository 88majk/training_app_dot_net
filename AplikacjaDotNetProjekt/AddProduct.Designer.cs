namespace AplikacjaDotNetProjekt
{
    partial class AddProduct
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
            selectSource_combo = new ComboBox();
            selectProductSource_label = new Label();
            log_label = new Label();
            writeProductAPI_textBox = new TextBox();
            writeProductAPI_label = new Label();
            searchAPI_button = new Button();
            apiResult_label = new Label();
            weightAPI_label = new Label();
            entryGramAPI_textBox = new TextBox();
            gAPI_label = new Label();
            nutriments_table = new DataGridView();
            Nutriments = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            addProduct_button = new Button();
            selectProduct_combo = new ComboBox();
            chooseProduct_label = new Label();
            productInfo_table = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            ProductValue = new DataGridViewTextBoxColumn();
            productInfo_label = new Label();
            weightChoose_label = new Label();
            entryGramChoose_textBox = new TextBox();
            gChoose_label = new Label();
            addProductChoose_button = new Button();
            nameNewProduct_label = new Label();
            kcalNewProduct_label = new Label();
            fatNewProduct_label = new Label();
            fiberNewProduct_label = new Label();
            proteinNewProduct_label = new Label();
            saltNewProduct_label = new Label();
            carbohydratesNewProduct_label = new Label();
            nameNewProduct_textBox = new TextBox();
            kcalNewProduct_textBox = new TextBox();
            fatNewProduct_textBox = new TextBox();
            fiberNewProduct_textBox = new TextBox();
            proteinNewProduct_textBox = new TextBox();
            saltNewProduct_textBox = new TextBox();
            carbohydratesNewProduct_textBox = new TextBox();
            gFat_label = new Label();
            gCarbohydrates_label = new Label();
            gSalt_label = new Label();
            gProtein_label = new Label();
            gFiber_label = new Label();
            weightNewProduct_label = new Label();
            entryWeightNewProduct_textBox = new TextBox();
            gWeightNewProduct_label = new Label();
            addProductNewProduct_button = new Button();
            newProduct_label = new Label();
            logNewProduct_label = new Label();
            ((System.ComponentModel.ISupportInitialize)nutriments_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInfo_table).BeginInit();
            SuspendLayout();
            // 
            // selectSource_combo
            // 
            selectSource_combo.FormattingEnabled = true;
            selectSource_combo.Location = new Point(141, 29);
            selectSource_combo.Name = "selectSource_combo";
            selectSource_combo.Size = new Size(164, 23);
            selectSource_combo.TabIndex = 0;
            // 
            // selectProductSource_label
            // 
            selectProductSource_label.AutoSize = true;
            selectProductSource_label.Location = new Point(159, 11);
            selectProductSource_label.Name = "selectProductSource_label";
            selectProductSource_label.Size = new Size(121, 15);
            selectProductSource_label.TabIndex = 1;
            selectProductSource_label.Text = "Select product source";
            // 
            // log_label
            // 
            log_label.AutoSize = true;
            log_label.ForeColor = Color.Red;
            log_label.Location = new Point(160, 154);
            log_label.Name = "log_label";
            log_label.Size = new Size(0, 15);
            log_label.TabIndex = 2;
            log_label.Resize += log_label_Resize;
            // 
            // writeProductAPI_textBox
            // 
            writeProductAPI_textBox.Location = new Point(141, 94);
            writeProductAPI_textBox.Name = "writeProductAPI_textBox";
            writeProductAPI_textBox.Size = new Size(164, 23);
            writeProductAPI_textBox.TabIndex = 3;
            writeProductAPI_textBox.Visible = false;
            // 
            // writeProductAPI_label
            // 
            writeProductAPI_label.AutoSize = true;
            writeProductAPI_label.Location = new Point(159, 76);
            writeProductAPI_label.Name = "writeProductAPI_label";
            writeProductAPI_label.Size = new Size(127, 15);
            writeProductAPI_label.TabIndex = 4;
            writeProductAPI_label.Text = "Write name of product";
            writeProductAPI_label.Visible = false;
            // 
            // searchAPI_button
            // 
            searchAPI_button.Location = new Point(186, 123);
            searchAPI_button.Name = "searchAPI_button";
            searchAPI_button.Size = new Size(75, 23);
            searchAPI_button.TabIndex = 5;
            searchAPI_button.Text = "Search";
            searchAPI_button.UseVisualStyleBackColor = true;
            searchAPI_button.Visible = false;
            searchAPI_button.Click += searchAPI_button_Click;
            // 
            // apiResult_label
            // 
            apiResult_label.AutoSize = true;
            apiResult_label.Location = new Point(12, 188);
            apiResult_label.Name = "apiResult_label";
            apiResult_label.Size = new Size(38, 15);
            apiResult_label.TabIndex = 6;
            apiResult_label.Text = "label1";
            apiResult_label.Visible = false;
            // 
            // weightAPI_label
            // 
            weightAPI_label.AutoSize = true;
            weightAPI_label.Location = new Point(12, 222);
            weightAPI_label.Name = "weightAPI_label";
            weightAPI_label.Size = new Size(45, 15);
            weightAPI_label.TabIndex = 7;
            weightAPI_label.Text = "Weight";
            weightAPI_label.Visible = false;
            // 
            // entryGramAPI_textBox
            // 
            entryGramAPI_textBox.Location = new Point(63, 219);
            entryGramAPI_textBox.Name = "entryGramAPI_textBox";
            entryGramAPI_textBox.Size = new Size(36, 23);
            entryGramAPI_textBox.TabIndex = 8;
            entryGramAPI_textBox.Text = "100";
            entryGramAPI_textBox.Visible = false;
            entryGramAPI_textBox.TextChanged += entryWeightAPI_textChanged;
            // 
            // gAPI_label
            // 
            gAPI_label.AutoSize = true;
            gAPI_label.Location = new Point(100, 222);
            gAPI_label.Name = "gAPI_label";
            gAPI_label.Size = new Size(14, 15);
            gAPI_label.TabIndex = 9;
            gAPI_label.Text = "g";
            gAPI_label.Visible = false;
            // 
            // nutriments_table
            // 
            nutriments_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nutriments_table.Columns.AddRange(new DataGridViewColumn[] { Nutriments, Value });
            nutriments_table.Location = new Point(14, 251);
            nutriments_table.Name = "nutriments_table";
            nutriments_table.RowTemplate.Height = 25;
            nutriments_table.Size = new Size(246, 206);
            nutriments_table.TabIndex = 10;
            nutriments_table.Visible = false;
            // 
            // Nutriments
            // 
            Nutriments.HeaderText = "Nutriments";
            Nutriments.Name = "Nutriments";
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            // 
            // addProduct_button
            // 
            addProduct_button.Location = new Point(295, 328);
            addProduct_button.Name = "addProduct_button";
            addProduct_button.Size = new Size(103, 38);
            addProduct_button.TabIndex = 11;
            addProduct_button.Text = "Add product";
            addProduct_button.UseVisualStyleBackColor = true;
            addProduct_button.Visible = false;
            addProduct_button.Click += addProduct_button_Click;
            // 
            // selectProduct_combo
            // 
            selectProduct_combo.FormattingEnabled = true;
            selectProduct_combo.Location = new Point(112, 76);
            selectProduct_combo.Name = "selectProduct_combo";
            selectProduct_combo.Size = new Size(222, 23);
            selectProduct_combo.TabIndex = 12;
            selectProduct_combo.Visible = false;
            selectProduct_combo.SelectedIndexChanged += selectProduct_combo_SelectedIndexChanged;
            // 
            // chooseProduct_label
            // 
            chooseProduct_label.AutoSize = true;
            chooseProduct_label.Location = new Point(169, 58);
            chooseProduct_label.Name = "chooseProduct_label";
            chooseProduct_label.Size = new Size(92, 15);
            chooseProduct_label.TabIndex = 13;
            chooseProduct_label.Text = "Choose product";
            chooseProduct_label.Visible = false;
            // 
            // productInfo_table
            // 
            productInfo_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productInfo_table.Columns.AddRange(new DataGridViewColumn[] { ProductName, ProductValue });
            productInfo_table.Location = new Point(100, 152);
            productInfo_table.Name = "productInfo_table";
            productInfo_table.RowTemplate.Height = 25;
            productInfo_table.Size = new Size(245, 214);
            productInfo_table.TabIndex = 14;
            productInfo_table.Visible = false;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Name";
            ProductName.Name = "ProductName";
            // 
            // ProductValue
            // 
            ProductValue.HeaderText = "Value";
            ProductValue.Name = "ProductValue";
            // 
            // productInfo_label
            // 
            productInfo_label.AutoSize = true;
            productInfo_label.Location = new Point(159, 127);
            productInfo_label.Name = "productInfo_label";
            productInfo_label.Size = new Size(118, 15);
            productInfo_label.TabIndex = 15;
            productInfo_label.Text = "Product infromation:";
            productInfo_label.Visible = false;
            // 
            // weightChoose_label
            // 
            weightChoose_label.AutoSize = true;
            weightChoose_label.Location = new Point(162, 378);
            weightChoose_label.Name = "weightChoose_label";
            weightChoose_label.Size = new Size(45, 15);
            weightChoose_label.TabIndex = 16;
            weightChoose_label.Text = "Weight";
            weightChoose_label.Visible = false;
            // 
            // entryGramChoose_textBox
            // 
            entryGramChoose_textBox.Location = new Point(213, 375);
            entryGramChoose_textBox.Name = "entryGramChoose_textBox";
            entryGramChoose_textBox.Size = new Size(36, 23);
            entryGramChoose_textBox.TabIndex = 17;
            entryGramChoose_textBox.Text = "100";
            entryGramChoose_textBox.Visible = false;
            // 
            // gChoose_label
            // 
            gChoose_label.AutoSize = true;
            gChoose_label.Location = new Point(254, 379);
            gChoose_label.Name = "gChoose_label";
            gChoose_label.Size = new Size(14, 15);
            gChoose_label.TabIndex = 18;
            gChoose_label.Text = "g";
            gChoose_label.Visible = false;
            // 
            // addProductChoose_button
            // 
            addProductChoose_button.Location = new Point(169, 404);
            addProductChoose_button.Name = "addProductChoose_button";
            addProductChoose_button.Size = new Size(103, 38);
            addProductChoose_button.TabIndex = 19;
            addProductChoose_button.Text = "Add product";
            addProductChoose_button.UseVisualStyleBackColor = true;
            addProductChoose_button.Visible = false;
            addProductChoose_button.Click += addProductChoose_button_Click;
            // 
            // nameNewProduct_label
            // 
            nameNewProduct_label.AutoSize = true;
            nameNewProduct_label.Location = new Point(49, 84);
            nameNewProduct_label.Name = "nameNewProduct_label";
            nameNewProduct_label.Size = new Size(39, 15);
            nameNewProduct_label.TabIndex = 20;
            nameNewProduct_label.Text = "Name";
            nameNewProduct_label.Visible = false;
            // 
            // kcalNewProduct_label
            // 
            kcalNewProduct_label.AutoSize = true;
            kcalNewProduct_label.Location = new Point(50, 130);
            kcalNewProduct_label.Name = "kcalNewProduct_label";
            kcalNewProduct_label.Size = new Size(29, 15);
            kcalNewProduct_label.TabIndex = 21;
            kcalNewProduct_label.Text = "Kcal";
            kcalNewProduct_label.Visible = false;
            // 
            // fatNewProduct_label
            // 
            fatNewProduct_label.AutoSize = true;
            fatNewProduct_label.Location = new Point(50, 173);
            fatNewProduct_label.Name = "fatNewProduct_label";
            fatNewProduct_label.Size = new Size(23, 15);
            fatNewProduct_label.TabIndex = 22;
            fatNewProduct_label.Text = "Fat";
            fatNewProduct_label.Visible = false;
            // 
            // fiberNewProduct_label
            // 
            fiberNewProduct_label.AutoSize = true;
            fiberNewProduct_label.Location = new Point(234, 84);
            fiberNewProduct_label.Name = "fiberNewProduct_label";
            fiberNewProduct_label.Size = new Size(33, 15);
            fiberNewProduct_label.TabIndex = 23;
            fiberNewProduct_label.Text = "Fiber";
            fiberNewProduct_label.Visible = false;
            // 
            // proteinNewProduct_label
            // 
            proteinNewProduct_label.AutoSize = true;
            proteinNewProduct_label.Location = new Point(234, 130);
            proteinNewProduct_label.Name = "proteinNewProduct_label";
            proteinNewProduct_label.Size = new Size(45, 15);
            proteinNewProduct_label.TabIndex = 24;
            proteinNewProduct_label.Text = "Protein";
            proteinNewProduct_label.Visible = false;
            // 
            // saltNewProduct_label
            // 
            saltNewProduct_label.AutoSize = true;
            saltNewProduct_label.Location = new Point(234, 173);
            saltNewProduct_label.Name = "saltNewProduct_label";
            saltNewProduct_label.Size = new Size(26, 15);
            saltNewProduct_label.TabIndex = 25;
            saltNewProduct_label.Text = "Salt";
            saltNewProduct_label.Visible = false;
            // 
            // carbohydratesNewProduct_label
            // 
            carbohydratesNewProduct_label.AutoSize = true;
            carbohydratesNewProduct_label.Location = new Point(50, 222);
            carbohydratesNewProduct_label.Name = "carbohydratesNewProduct_label";
            carbohydratesNewProduct_label.Size = new Size(84, 15);
            carbohydratesNewProduct_label.TabIndex = 26;
            carbohydratesNewProduct_label.Text = "Carbohydrates";
            carbohydratesNewProduct_label.Visible = false;
            // 
            // nameNewProduct_textBox
            // 
            nameNewProduct_textBox.Location = new Point(94, 77);
            nameNewProduct_textBox.Name = "nameNewProduct_textBox";
            nameNewProduct_textBox.Size = new Size(134, 23);
            nameNewProduct_textBox.TabIndex = 27;
            nameNewProduct_textBox.Visible = false;
            // 
            // kcalNewProduct_textBox
            // 
            kcalNewProduct_textBox.Location = new Point(94, 127);
            kcalNewProduct_textBox.Name = "kcalNewProduct_textBox";
            kcalNewProduct_textBox.Size = new Size(134, 23);
            kcalNewProduct_textBox.TabIndex = 28;
            kcalNewProduct_textBox.Visible = false;
            // 
            // fatNewProduct_textBox
            // 
            fatNewProduct_textBox.Location = new Point(94, 170);
            fatNewProduct_textBox.Name = "fatNewProduct_textBox";
            fatNewProduct_textBox.Size = new Size(86, 23);
            fatNewProduct_textBox.TabIndex = 29;
            fatNewProduct_textBox.Visible = false;
            // 
            // fiberNewProduct_textBox
            // 
            fiberNewProduct_textBox.Location = new Point(278, 76);
            fiberNewProduct_textBox.Name = "fiberNewProduct_textBox";
            fiberNewProduct_textBox.Size = new Size(86, 23);
            fiberNewProduct_textBox.TabIndex = 30;
            fiberNewProduct_textBox.Visible = false;
            // 
            // proteinNewProduct_textBox
            // 
            proteinNewProduct_textBox.Location = new Point(278, 124);
            proteinNewProduct_textBox.Name = "proteinNewProduct_textBox";
            proteinNewProduct_textBox.Size = new Size(86, 23);
            proteinNewProduct_textBox.TabIndex = 31;
            proteinNewProduct_textBox.Visible = false;
            // 
            // saltNewProduct_textBox
            // 
            saltNewProduct_textBox.Location = new Point(278, 170);
            saltNewProduct_textBox.Name = "saltNewProduct_textBox";
            saltNewProduct_textBox.Size = new Size(86, 23);
            saltNewProduct_textBox.TabIndex = 32;
            saltNewProduct_textBox.Visible = false;
            // 
            // carbohydratesNewProduct_textBox
            // 
            carbohydratesNewProduct_textBox.Location = new Point(142, 219);
            carbohydratesNewProduct_textBox.Name = "carbohydratesNewProduct_textBox";
            carbohydratesNewProduct_textBox.Size = new Size(86, 23);
            carbohydratesNewProduct_textBox.TabIndex = 33;
            carbohydratesNewProduct_textBox.Visible = false;
            // 
            // gFat_label
            // 
            gFat_label.AutoSize = true;
            gFat_label.Location = new Point(186, 173);
            gFat_label.Name = "gFat_label";
            gFat_label.Size = new Size(14, 15);
            gFat_label.TabIndex = 35;
            gFat_label.Text = "g";
            gFat_label.Visible = false;
            // 
            // gCarbohydrates_label
            // 
            gCarbohydrates_label.AutoSize = true;
            gCarbohydrates_label.Location = new Point(234, 222);
            gCarbohydrates_label.Name = "gCarbohydrates_label";
            gCarbohydrates_label.Size = new Size(14, 15);
            gCarbohydrates_label.TabIndex = 36;
            gCarbohydrates_label.Text = "g";
            gCarbohydrates_label.Visible = false;
            // 
            // gSalt_label
            // 
            gSalt_label.AutoSize = true;
            gSalt_label.Location = new Point(370, 173);
            gSalt_label.Name = "gSalt_label";
            gSalt_label.Size = new Size(14, 15);
            gSalt_label.TabIndex = 37;
            gSalt_label.Text = "g";
            gSalt_label.Visible = false;
            // 
            // gProtein_label
            // 
            gProtein_label.AutoSize = true;
            gProtein_label.Location = new Point(370, 127);
            gProtein_label.Name = "gProtein_label";
            gProtein_label.Size = new Size(14, 15);
            gProtein_label.TabIndex = 38;
            gProtein_label.Text = "g";
            gProtein_label.Visible = false;
            // 
            // gFiber_label
            // 
            gFiber_label.AutoSize = true;
            gFiber_label.Location = new Point(370, 80);
            gFiber_label.Name = "gFiber_label";
            gFiber_label.Size = new Size(14, 15);
            gFiber_label.TabIndex = 39;
            gFiber_label.Text = "g";
            gFiber_label.Visible = false;
            // 
            // weightNewProduct_label
            // 
            weightNewProduct_label.AutoSize = true;
            weightNewProduct_label.Location = new Point(162, 265);
            weightNewProduct_label.Name = "weightNewProduct_label";
            weightNewProduct_label.Size = new Size(45, 15);
            weightNewProduct_label.TabIndex = 40;
            weightNewProduct_label.Text = "Weight";
            weightNewProduct_label.Visible = false;
            // 
            // entryWeightNewProduct_textBox
            // 
            entryWeightNewProduct_textBox.Location = new Point(212, 262);
            entryWeightNewProduct_textBox.Name = "entryWeightNewProduct_textBox";
            entryWeightNewProduct_textBox.Size = new Size(36, 23);
            entryWeightNewProduct_textBox.TabIndex = 41;
            entryWeightNewProduct_textBox.Text = "100";
            entryWeightNewProduct_textBox.Visible = false;
            // 
            // gWeightNewProduct_label
            // 
            gWeightNewProduct_label.AutoSize = true;
            gWeightNewProduct_label.Location = new Point(253, 265);
            gWeightNewProduct_label.Name = "gWeightNewProduct_label";
            gWeightNewProduct_label.Size = new Size(14, 15);
            gWeightNewProduct_label.TabIndex = 42;
            gWeightNewProduct_label.Text = "g";
            gWeightNewProduct_label.Visible = false;
            // 
            // addProductNewProduct_button
            // 
            addProductNewProduct_button.Location = new Point(169, 291);
            addProductNewProduct_button.Name = "addProductNewProduct_button";
            addProductNewProduct_button.Size = new Size(103, 38);
            addProductNewProduct_button.TabIndex = 43;
            addProductNewProduct_button.Text = "Add product";
            addProductNewProduct_button.UseVisualStyleBackColor = true;
            addProductNewProduct_button.Visible = false;
            addProductNewProduct_button.Click += addProductNewProduct_button_Click;
            // 
            // newProduct_label
            // 
            newProduct_label.AutoSize = true;
            newProduct_label.Location = new Point(126, 55);
            newProduct_label.Name = "newProduct_label";
            newProduct_label.Size = new Size(193, 15);
            newProduct_label.TabIndex = 44;
            newProduct_label.Text = "Enter product information per 100g";
            newProduct_label.Visible = false;
            // 
            // logNewProduct_label
            // 
            logNewProduct_label.AutoSize = true;
            logNewProduct_label.Location = new Point(169, 340);
            logNewProduct_label.Name = "logNewProduct_label";
            logNewProduct_label.Size = new Size(0, 15);
            logNewProduct_label.TabIndex = 45;
            logNewProduct_label.Visible = false;
            logNewProduct_label.Resize += logNewProduct_resize;
            logNewProduct_label.ForeColor = Color.Red;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 509);
            Controls.Add(logNewProduct_label);
            Controls.Add(newProduct_label);
            Controls.Add(addProductNewProduct_button);
            Controls.Add(gWeightNewProduct_label);
            Controls.Add(entryWeightNewProduct_textBox);
            Controls.Add(weightNewProduct_label);
            Controls.Add(gFiber_label);
            Controls.Add(gProtein_label);
            Controls.Add(gSalt_label);
            Controls.Add(gCarbohydrates_label);
            Controls.Add(gFat_label);
            Controls.Add(carbohydratesNewProduct_textBox);
            Controls.Add(saltNewProduct_textBox);
            Controls.Add(proteinNewProduct_textBox);
            Controls.Add(fiberNewProduct_textBox);
            Controls.Add(fatNewProduct_textBox);
            Controls.Add(kcalNewProduct_textBox);
            Controls.Add(nameNewProduct_textBox);
            Controls.Add(carbohydratesNewProduct_label);
            Controls.Add(saltNewProduct_label);
            Controls.Add(proteinNewProduct_label);
            Controls.Add(fiberNewProduct_label);
            Controls.Add(fatNewProduct_label);
            Controls.Add(kcalNewProduct_label);
            Controls.Add(nameNewProduct_label);
            Controls.Add(addProductChoose_button);
            Controls.Add(gChoose_label);
            Controls.Add(entryGramChoose_textBox);
            Controls.Add(weightChoose_label);
            Controls.Add(productInfo_label);
            Controls.Add(productInfo_table);
            Controls.Add(chooseProduct_label);
            Controls.Add(selectProduct_combo);
            Controls.Add(addProduct_button);
            Controls.Add(nutriments_table);
            Controls.Add(gAPI_label);
            Controls.Add(entryGramAPI_textBox);
            Controls.Add(weightAPI_label);
            Controls.Add(apiResult_label);
            Controls.Add(searchAPI_button);
            Controls.Add(writeProductAPI_label);
            Controls.Add(writeProductAPI_textBox);
            Controls.Add(log_label);
            Controls.Add(selectProductSource_label);
            Controls.Add(selectSource_combo);
            Name = "AddProduct";
            Text = "Add product";
            ((System.ComponentModel.ISupportInitialize)nutriments_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInfo_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectSource_combo;
        private Label selectProductSource_label;
        private Label log_label;
        private TextBox writeProductAPI_textBox;
        private Label writeProductAPI_label;
        private Button searchAPI_button;
        private Label apiResult_label;
        private Label weightAPI_label;
        private TextBox entryGramAPI_textBox;
        private Label gAPI_label;
        private DataGridView nutriments_table;
        private DataGridViewTextBoxColumn Nutriments;
        private DataGridViewTextBoxColumn Value;
        private Button addProduct_button;
        private ComboBox selectProduct_combo;
        private Label chooseProduct_label;
        private DataGridView productInfo_table;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductValue;
        private DataGridView dataGridView1;
        private Label productInfo_label;
        private Label weightChoose_label;
        private TextBox entryGramChoose_textBox;
        private Label gChoose_label;
        private Button addProductChoose_button;
        private Label nameNewProduct_label;
        private Label kcalNewProduct_label;
        private Label fatNewProduct_label;
        private Label fiberNewProduct_label;
        private Label proteinNewProduct_label;
        private Label saltNewProduct_label;
        private Label carbohydratesNewProduct_label;
        private TextBox nameNewProduct_textBox;
        private TextBox kcalNewProduct_textBox;
        private TextBox fatNewProduct_textBox;
        private TextBox fiberNewProduct_textBox;
        private TextBox proteinNewProduct_textBox;
        private TextBox saltNewProduct_textBox;
        private TextBox carbohydratesNewProduct_textBox;
        private Label gFat_label;
        private Label gCarbohydrates_label;
        private Label gSalt_label;
        private Label gProtein_label;
        private Label gFiber_label;
        private Label weightNewProduct_label;
        private TextBox entryWeightNewProduct_textBox;
        private Label gWeightNewProduct_label;
        private Button addProductNewProduct_button;
        private Label newProduct_label;
        private Label logNewProduct_label;
    }
}