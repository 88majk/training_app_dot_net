namespace AplikacjaDotNetProjekt
{
    partial class AddTraining
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
            selectTraining_button = new Button();
            addNewTraining_button = new Button();
            muscleParts_comboBox = new ComboBox();
            addTraining_panel = new Panel();
            trainingName_label = new Label();
            trainingName_textBox = new TextBox();
            addExercise_button = new Button();
            searchExercise_textBox = new TextBox();
            exercises_comboBox = new ComboBox();
            selectMuscleParts_label = new Label();
            addTraining_panel.SuspendLayout();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            title_label.Location = new Point(305, 21);
            title_label.Name = "title_label";
            title_label.Size = new Size(99, 32);
            title_label.TabIndex = 0;
            title_label.Text = "Training";
            // 
            // selectTraining_button
            // 
            selectTraining_button.Location = new Point(140, 74);
            selectTraining_button.Name = "selectTraining_button";
            selectTraining_button.Size = new Size(159, 83);
            selectTraining_button.TabIndex = 1;
            selectTraining_button.Text = "Select training from your available";
            selectTraining_button.UseVisualStyleBackColor = true;
            // 
            // addNewTraining_button
            // 
            addNewTraining_button.Location = new Point(413, 74);
            addNewTraining_button.Name = "addNewTraining_button";
            addNewTraining_button.Size = new Size(159, 83);
            addNewTraining_button.TabIndex = 2;
            addNewTraining_button.Text = "Add new training set";
            addNewTraining_button.UseVisualStyleBackColor = true;
            addNewTraining_button.Click += addNewTraining_button_Click;
            // 
            // muscleParts_comboBox
            // 
            muscleParts_comboBox.FormattingEnabled = true;
            muscleParts_comboBox.Location = new Point(226, 109);
            muscleParts_comboBox.Name = "muscleParts_comboBox";
            muscleParts_comboBox.Size = new Size(184, 28);
            muscleParts_comboBox.TabIndex = 3;
            muscleParts_comboBox.SelectedIndexChanged += muscleParts_comboBox_SelectedIndexChanged;
            // 
            // addTraining_panel
            // 
            addTraining_panel.Controls.Add(trainingName_label);
            addTraining_panel.Controls.Add(trainingName_textBox);
            addTraining_panel.Controls.Add(addExercise_button);
            addTraining_panel.Controls.Add(searchExercise_textBox);
            addTraining_panel.Controls.Add(exercises_comboBox);
            addTraining_panel.Controls.Add(selectMuscleParts_label);
            addTraining_panel.Controls.Add(muscleParts_comboBox);
            addTraining_panel.Location = new Point(39, 56);
            addTraining_panel.Name = "addTraining_panel";
            addTraining_panel.Size = new Size(645, 364);
            addTraining_panel.TabIndex = 4;
            addTraining_panel.Visible = false;
            // 
            // trainingName_label
            // 
            trainingName_label.AutoSize = true;
            trainingName_label.Location = new Point(243, 9);
            trainingName_label.Name = "trainingName_label";
            trainingName_label.Size = new Size(137, 20);
            trainingName_label.TabIndex = 9;
            trainingName_label.Text = "Name your training";
            // 
            // trainingName_textBox
            // 
            trainingName_textBox.Location = new Point(228, 34);
            trainingName_textBox.Name = "trainingName_textBox";
            trainingName_textBox.Size = new Size(182, 27);
            trainingName_textBox.TabIndex = 8;
            trainingName_textBox.Text = "...";
            // 
            // addExercise_button
            // 
            addExercise_button.Location = new Point(256, 251);
            addExercise_button.Name = "addExercise_button";
            addExercise_button.Size = new Size(117, 29);
            addExercise_button.TabIndex = 7;
            addExercise_button.Text = "Add exercise";
            addExercise_button.UseVisualStyleBackColor = true;
            // 
            // searchExercise_textBox
            // 
            searchExercise_textBox.Location = new Point(228, 169);
            searchExercise_textBox.Name = "searchExercise_textBox";
            searchExercise_textBox.Size = new Size(182, 27);
            searchExercise_textBox.TabIndex = 6;
            searchExercise_textBox.Text = "Search exercise...";
            // 
            // exercises_comboBox
            // 
            exercises_comboBox.FormattingEnabled = true;
            exercises_comboBox.Location = new Point(226, 202);
            exercises_comboBox.Name = "exercises_comboBox";
            exercises_comboBox.Size = new Size(184, 28);
            exercises_comboBox.TabIndex = 5;
            // 
            // selectMuscleParts_label
            // 
            selectMuscleParts_label.AutoSize = true;
            selectMuscleParts_label.Location = new Point(241, 80);
            selectMuscleParts_label.Name = "selectMuscleParts_label";
            selectMuscleParts_label.Size = new Size(139, 20);
            selectMuscleParts_label.TabIndex = 4;
            selectMuscleParts_label.Text = "Select muscle parts:";
            // 
            // AddTraining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 548);
            Controls.Add(addTraining_panel);
            Controls.Add(addNewTraining_button);
            Controls.Add(selectTraining_button);
            Controls.Add(title_label);
            Name = "AddTraining";
            Text = "AddTraining";
            addTraining_panel.ResumeLayout(false);
            addTraining_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_label;
        private Button selectTraining_button;
        private Button addNewTraining_button;
        private ComboBox muscleParts_comboBox;
        private Panel addTraining_panel;
        private Label selectMuscleParts_label;
        private TextBox searchExercise_textBox;
        private ComboBox exercises_comboBox;
        private Button addExercise_button;
        private Label trainingName_label;
        private TextBox trainingName_textBox;
    }
}