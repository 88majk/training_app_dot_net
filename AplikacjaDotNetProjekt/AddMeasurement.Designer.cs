namespace AplikacjaDotNetProjekt
{
    partial class AddMeasurement
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
            title_label = new Label();
            measurementsHistory_dataGridView = new DataGridView();
            height_textBox = new TextBox();
            weight_textBox = new TextBox();
            armCircuit_textBox = new TextBox();
            chestCircuit_textBox = new TextBox();
            height_label = new Label();
            weight_label = new Label();
            armCircuit_label = new Label();
            chestCircuit_label = new Label();
            saveMeasurement_button = new Button();
            error_label = new Label();
            cm_label1 = new Label();
            cm_label2 = new Label();
            cm_label3 = new Label();
            kg_label = new Label();
            yourHisotry_label = new Label();
            ((System.ComponentModel.ISupportInitialize)measurementsHistory_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            title_label.Location = new Point(25, 9);
            title_label.Name = "title_label";
            title_label.Size = new Size(156, 30);
            title_label.TabIndex = 0;
            title_label.Text = "Measurements";
            // 
            // measurementsHistory_dataGridView
            // 
            measurementsHistory_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            measurementsHistory_dataGridView.Location = new Point(249, 55);
            measurementsHistory_dataGridView.Name = "measurementsHistory_dataGridView";
            measurementsHistory_dataGridView.RowHeadersWidth = 51;
            measurementsHistory_dataGridView.RowTemplate.Height = 29;
            measurementsHistory_dataGridView.Size = new Size(648, 198);
            measurementsHistory_dataGridView.TabIndex = 1;
            // 
            // height_textBox
            // 
            height_textBox.Location = new Point(125, 58);
            height_textBox.Name = "height_textBox";
            height_textBox.Size = new Size(56, 27);
            height_textBox.TabIndex = 2;
            // 
            // weight_textBox
            // 
            weight_textBox.Location = new Point(125, 111);
            weight_textBox.Name = "weight_textBox";
            weight_textBox.Size = new Size(56, 27);
            weight_textBox.TabIndex = 3;
            // 
            // armCircuit_textBox
            // 
            armCircuit_textBox.Location = new Point(125, 163);
            armCircuit_textBox.Name = "armCircuit_textBox";
            armCircuit_textBox.Size = new Size(56, 27);
            armCircuit_textBox.TabIndex = 4;
            // 
            // chestCircuit_textBox
            // 
            chestCircuit_textBox.Location = new Point(125, 208);
            chestCircuit_textBox.Name = "chestCircuit_textBox";
            chestCircuit_textBox.Size = new Size(56, 27);
            chestCircuit_textBox.TabIndex = 5;
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(33, 61);
            height_label.Name = "height_label";
            height_label.Size = new Size(57, 20);
            height_label.TabIndex = 6;
            height_label.Text = "Height:";
            // 
            // weight_label
            // 
            weight_label.AutoSize = true;
            weight_label.Location = new Point(31, 114);
            weight_label.Name = "weight_label";
            weight_label.Size = new Size(59, 20);
            weight_label.TabIndex = 7;
            weight_label.Text = "Weight:";
            // 
            // armCircuit_label
            // 
            armCircuit_label.AutoSize = true;
            armCircuit_label.Location = new Point(23, 166);
            armCircuit_label.Name = "armCircuit_label";
            armCircuit_label.Size = new Size(84, 20);
            armCircuit_label.TabIndex = 8;
            armCircuit_label.Text = "Arm circuit:";
            // 
            // chestCircuit_label
            // 
            chestCircuit_label.AutoSize = true;
            chestCircuit_label.Location = new Point(23, 211);
            chestCircuit_label.Name = "chestCircuit_label";
            chestCircuit_label.Size = new Size(92, 20);
            chestCircuit_label.TabIndex = 9;
            chestCircuit_label.Text = "Chest circuit:";
            // 
            // saveMeasurement_button
            // 
            saveMeasurement_button.Location = new Point(23, 256);
            saveMeasurement_button.Name = "saveMeasurement_button";
            saveMeasurement_button.Size = new Size(187, 29);
            saveMeasurement_button.TabIndex = 10;
            saveMeasurement_button.Text = "Save measurement";
            saveMeasurement_button.UseVisualStyleBackColor = true;
            saveMeasurement_button.Click += saveMeasurement_button_Click;
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.Location = new Point(25, 288);
            error_label.Name = "error_label";
            error_label.Size = new Size(50, 20);
            error_label.TabIndex = 11;
            error_label.Text = "label1";
            // 
            // cm_label1
            // 
            cm_label1.AutoSize = true;
            cm_label1.Location = new Point(185, 61);
            cm_label1.Name = "cm_label1";
            cm_label1.Size = new Size(29, 20);
            cm_label1.TabIndex = 12;
            cm_label1.Text = "cm";
            // 
            // cm_label2
            // 
            cm_label2.AutoSize = true;
            cm_label2.Location = new Point(185, 166);
            cm_label2.Name = "cm_label2";
            cm_label2.Size = new Size(29, 20);
            cm_label2.TabIndex = 13;
            cm_label2.Text = "cm";
            // 
            // cm_label3
            // 
            cm_label3.AutoSize = true;
            cm_label3.Location = new Point(185, 211);
            cm_label3.Name = "cm_label3";
            cm_label3.Size = new Size(29, 20);
            cm_label3.TabIndex = 14;
            cm_label3.Text = "cm";
            // 
            // kg_label
            // 
            kg_label.AutoSize = true;
            kg_label.Location = new Point(185, 114);
            kg_label.Name = "kg_label";
            kg_label.Size = new Size(25, 20);
            kg_label.TabIndex = 15;
            kg_label.Text = "kg";
            // 
            // yourHisotry_label
            // 
            yourHisotry_label.AutoSize = true;
            yourHisotry_label.Location = new Point(249, 32);
            yourHisotry_label.Name = "yourHisotry_label";
            yourHisotry_label.Size = new Size(183, 20);
            yourHisotry_label.TabIndex = 16;
            yourHisotry_label.Text = "Your measurement history:";
            // 
            // AddMeasurement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 368);
            Controls.Add(yourHisotry_label);
            Controls.Add(kg_label);
            Controls.Add(cm_label3);
            Controls.Add(cm_label2);
            Controls.Add(cm_label1);
            Controls.Add(error_label);
            Controls.Add(saveMeasurement_button);
            Controls.Add(chestCircuit_label);
            Controls.Add(armCircuit_label);
            Controls.Add(weight_label);
            Controls.Add(height_label);
            Controls.Add(chestCircuit_textBox);
            Controls.Add(armCircuit_textBox);
            Controls.Add(weight_textBox);
            Controls.Add(height_textBox);
            Controls.Add(measurementsHistory_dataGridView);
            Controls.Add(title_label);
            Name = "AddMeasurement";
            ((System.ComponentModel.ISupportInitialize)measurementsHistory_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_label;
        private DataGridView measurementsHistory_dataGridView;
        private TextBox height_textBox;
        private TextBox weight_textBox;
        private TextBox armCircuit_textBox;
        private TextBox chestCircuit_textBox;
        private Label height_label;
        private Label weight_label;
        private Label armCircuit_label;
        private Label chestCircuit_label;
        private Button saveMeasurement_button;
        private Label error_label;
        private Label cm_label1;
        private Label cm_label2;
        private Label cm_label3;
        private Label kg_label;
        private Label yourHisotry_label;
    }
}