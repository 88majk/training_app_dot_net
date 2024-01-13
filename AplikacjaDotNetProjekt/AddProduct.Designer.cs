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
            SuspendLayout();
            // 
            // selectSource_combo
            // 
            selectSource_combo.FormattingEnabled = true;
            selectSource_combo.Location = new Point(100, 52);
            selectSource_combo.Name = "selectSource_combo";
            selectSource_combo.Size = new Size(164, 23);
            selectSource_combo.TabIndex = 0;
            // 
            // selectProductSource_label
            // 
            selectProductSource_label.AutoSize = true;
            selectProductSource_label.Location = new Point(118, 34);
            selectProductSource_label.Name = "selectProductSource_label";
            selectProductSource_label.Size = new Size(121, 15);
            selectProductSource_label.TabIndex = 1;
            selectProductSource_label.Text = "Select product source";
            // 
            // log_label
            // 
            log_label.AutoSize = true;
            log_label.Location = new Point(302, 52);
            log_label.Name = "log_label";
            log_label.Size = new Size(0, 15);
            log_label.TabIndex = 2;
            // 
            // writeProductAPI_textBox
            // 
            writeProductAPI_textBox.Location = new Point(100, 117);
            writeProductAPI_textBox.Name = "writeProductAPI_textBox";
            writeProductAPI_textBox.Size = new Size(164, 23);
            writeProductAPI_textBox.TabIndex = 3;
            writeProductAPI_textBox.Visible = false;
            // 
            // writeProductAPI_label
            // 
            writeProductAPI_label.AutoSize = true;
            writeProductAPI_label.Location = new Point(118, 99);
            writeProductAPI_label.Name = "writeProductAPI_label";
            writeProductAPI_label.Size = new Size(127, 15);
            writeProductAPI_label.TabIndex = 4;
            writeProductAPI_label.Text = "Write name of product";
            writeProductAPI_label.Visible = false;
            // 
            // searchAPI_button
            // 
            searchAPI_button.Location = new Point(144, 146);
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
            apiResult_label.Location = new Point(162, 182);
            apiResult_label.Name = "apiResult_label";
            apiResult_label.Size = new Size(38, 15);
            apiResult_label.TabIndex = 6;
            apiResult_label.Text = "label1";
            apiResult_label.Visible = false;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(apiResult_label);
            Controls.Add(searchAPI_button);
            Controls.Add(writeProductAPI_label);
            Controls.Add(writeProductAPI_textBox);
            Controls.Add(log_label);
            Controls.Add(selectProductSource_label);
            Controls.Add(selectSource_combo);
            Name = "AddProduct";
            Text = "Form1";
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
    }
}