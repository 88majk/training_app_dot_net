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
            ((System.ComponentModel.ISupportInitialize)nutriments_table).BeginInit();
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
            log_label.Location = new Point(159, 154);
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
            searchAPI_button.Location = new Point(185, 123);
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
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 509);
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
    }
}