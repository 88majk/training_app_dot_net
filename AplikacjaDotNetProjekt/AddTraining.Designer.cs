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
            addTraining_panel = new Panel();
            saveWorkout_button = new Button();
            titleTraininig_label = new Label();
            error_label = new Label();
            kgUnit_label = new Label();
            trainingDetails_listBox = new ListBox();
            weight_textBox = new TextBox();
            reps_textBox = new TextBox();
            sets_textBox = new TextBox();
            check_label = new Label();
            muscleParts_comboBox = new CheckedListBox();
            chooseExercise_label = new Label();
            addExercise_button = new Button();
            searchExercise_textBox = new TextBox();
            exercises_comboBox = new ComboBox();
            selectMuscleParts_label = new Label();
            selectTraining_panel = new Panel();
            label3 = new Label();
            loadWorkout_button = new Button();
            label1 = new Label();
            workout_dataGridView = new DataGridView();
            savedTrainings_comboBox = new ComboBox();
            addNewExercise_panel = new Panel();
            addNewExercise_checkecComboBox = new CheckedListBox();
            logExercise_label = new Label();
            addNewExercise_label = new Label();
            newExerciseName_textBox = new TextBox();
            addNewExercise2DB_button = new Button();
            label2 = new Label();
            nameTraining_panel = new Panel();
            nameTraining_button = new Button();
            trainingName_label = new Label();
            trainingName_textBox = new TextBox();
            addNewExercise_button = new Button();
            addTraining_panel.SuspendLayout();
            selectTraining_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workout_dataGridView).BeginInit();
            addNewExercise_panel.SuspendLayout();
            nameTraining_panel.SuspendLayout();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            title_label.Location = new Point(371, 22);
            title_label.Name = "title_label";
            title_label.Size = new Size(99, 32);
            title_label.TabIndex = 0;
            title_label.Text = "Training";
            // 
            // selectTraining_button
            // 
            selectTraining_button.Location = new Point(129, 71);
            selectTraining_button.Name = "selectTraining_button";
            selectTraining_button.Size = new Size(159, 83);
            selectTraining_button.TabIndex = 1;
            selectTraining_button.Text = "Select training from your available";
            selectTraining_button.UseVisualStyleBackColor = true;
            selectTraining_button.Click += selectTraining_button_Click;
            // 
            // addNewTraining_button
            // 
            addNewTraining_button.Location = new Point(545, 71);
            addNewTraining_button.Name = "addNewTraining_button";
            addNewTraining_button.Size = new Size(159, 83);
            addNewTraining_button.TabIndex = 2;
            addNewTraining_button.Text = "Add new training set";
            addNewTraining_button.UseVisualStyleBackColor = true;
            addNewTraining_button.Click += addNewTraining_button_Click;
            // 
            // addTraining_panel
            // 
            addTraining_panel.Controls.Add(saveWorkout_button);
            addTraining_panel.Controls.Add(titleTraininig_label);
            addTraining_panel.Controls.Add(error_label);
            addTraining_panel.Controls.Add(kgUnit_label);
            addTraining_panel.Controls.Add(trainingDetails_listBox);
            addTraining_panel.Controls.Add(weight_textBox);
            addTraining_panel.Controls.Add(reps_textBox);
            addTraining_panel.Controls.Add(sets_textBox);
            addTraining_panel.Controls.Add(check_label);
            addTraining_panel.Controls.Add(muscleParts_comboBox);
            addTraining_panel.Controls.Add(chooseExercise_label);
            addTraining_panel.Controls.Add(addExercise_button);
            addTraining_panel.Controls.Add(searchExercise_textBox);
            addTraining_panel.Controls.Add(exercises_comboBox);
            addTraining_panel.Controls.Add(selectMuscleParts_label);
            addTraining_panel.Location = new Point(12, 71);
            addTraining_panel.Name = "addTraining_panel";
            addTraining_panel.Size = new Size(834, 447);
            addTraining_panel.TabIndex = 4;
            addTraining_panel.Visible = false;
            // 
            // saveWorkout_button
            // 
            saveWorkout_button.Location = new Point(549, 262);
            saveWorkout_button.Name = "saveWorkout_button";
            saveWorkout_button.Size = new Size(128, 29);
            saveWorkout_button.TabIndex = 23;
            saveWorkout_button.Text = "Save workout";
            saveWorkout_button.UseVisualStyleBackColor = true;
            saveWorkout_button.Click += saveWorkout_button_Click;
            // 
            // titleTraininig_label
            // 
            titleTraininig_label.AutoSize = true;
            titleTraininig_label.Location = new Point(538, 31);
            titleTraininig_label.Name = "titleTraininig_label";
            titleTraininig_label.Size = new Size(151, 20);
            titleTraininig_label.TabIndex = 22;
            titleTraininig_label.Text = "Your current exercises";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.Location = new Point(82, 332);
            error_label.Name = "error_label";
            error_label.Size = new Size(22, 20);
            error_label.TabIndex = 21;
            error_label.Text = "id";
            // 
            // kgUnit_label
            // 
            kgUnit_label.AutoSize = true;
            kgUnit_label.Location = new Point(280, 299);
            kgUnit_label.Name = "kgUnit_label";
            kgUnit_label.Size = new Size(25, 20);
            kgUnit_label.TabIndex = 19;
            kgUnit_label.Text = "kg";
            // 
            // trainingDetails_listBox
            // 
            trainingDetails_listBox.FormattingEnabled = true;
            trainingDetails_listBox.ItemHeight = 20;
            trainingDetails_listBox.Location = new Point(400, 60);
            trainingDetails_listBox.Name = "trainingDetails_listBox";
            trainingDetails_listBox.Size = new Size(423, 184);
            trainingDetails_listBox.TabIndex = 18;
            // 
            // weight_textBox
            // 
            weight_textBox.Location = new Point(218, 296);
            weight_textBox.Name = "weight_textBox";
            weight_textBox.Size = new Size(62, 27);
            weight_textBox.TabIndex = 17;
            weight_textBox.Text = "Weight";
            // 
            // reps_textBox
            // 
            reps_textBox.Location = new Point(150, 296);
            reps_textBox.Name = "reps_textBox";
            reps_textBox.Size = new Size(62, 27);
            reps_textBox.TabIndex = 16;
            reps_textBox.Text = "Reps";
            // 
            // sets_textBox
            // 
            sets_textBox.Location = new Point(82, 296);
            sets_textBox.Name = "sets_textBox";
            sets_textBox.Size = new Size(62, 27);
            sets_textBox.TabIndex = 14;
            sets_textBox.Text = "Sets";
            // 
            // check_label
            // 
            check_label.AutoSize = true;
            check_label.Location = new Point(117, 10);
            check_label.Name = "check_label";
            check_label.Size = new Size(50, 20);
            check_label.TabIndex = 13;
            check_label.Text = "label1";
            // 
            // muscleParts_comboBox
            // 
            muscleParts_comboBox.BorderStyle = BorderStyle.FixedSingle;
            muscleParts_comboBox.FormattingEnabled = true;
            muscleParts_comboBox.Location = new Point(61, 63);
            muscleParts_comboBox.Name = "muscleParts_comboBox";
            muscleParts_comboBox.Size = new Size(254, 112);
            muscleParts_comboBox.TabIndex = 12;
            // 
            // chooseExercise_label
            // 
            chooseExercise_label.AutoSize = true;
            chooseExercise_label.Location = new Point(117, 185);
            chooseExercise_label.Name = "chooseExercise_label";
            chooseExercise_label.Size = new Size(118, 20);
            chooseExercise_label.TabIndex = 10;
            chooseExercise_label.Text = "Choose exercise:";
            // 
            // addExercise_button
            // 
            addExercise_button.Location = new Point(119, 361);
            addExercise_button.Name = "addExercise_button";
            addExercise_button.Size = new Size(117, 29);
            addExercise_button.TabIndex = 7;
            addExercise_button.Text = "Add exercise";
            addExercise_button.UseVisualStyleBackColor = true;
            addExercise_button.Click += addExercise_button_Click;
            // 
            // searchExercise_textBox
            // 
            searchExercise_textBox.Location = new Point(27, 245);
            searchExercise_textBox.Name = "searchExercise_textBox";
            searchExercise_textBox.Size = new Size(305, 27);
            searchExercise_textBox.TabIndex = 6;
            searchExercise_textBox.Text = "Search exercise...";
            // 
            // exercises_comboBox
            // 
            exercises_comboBox.FormattingEnabled = true;
            exercises_comboBox.Location = new Point(29, 209);
            exercises_comboBox.Name = "exercises_comboBox";
            exercises_comboBox.Size = new Size(303, 28);
            exercises_comboBox.TabIndex = 5;
            exercises_comboBox.MouseClick += exercises_comboBox_MouseClick;
            // 
            // selectMuscleParts_label
            // 
            selectMuscleParts_label.AutoSize = true;
            selectMuscleParts_label.Location = new Point(117, 40);
            selectMuscleParts_label.Name = "selectMuscleParts_label";
            selectMuscleParts_label.Size = new Size(139, 20);
            selectMuscleParts_label.TabIndex = 4;
            selectMuscleParts_label.Text = "Select muscle parts:";
            // 
            // selectTraining_panel
            // 
            selectTraining_panel.Controls.Add(label3);
            selectTraining_panel.Controls.Add(loadWorkout_button);
            selectTraining_panel.Controls.Add(label1);
            selectTraining_panel.Controls.Add(workout_dataGridView);
            selectTraining_panel.Controls.Add(savedTrainings_comboBox);
            selectTraining_panel.Location = new Point(-2, 91);
            selectTraining_panel.Name = "selectTraining_panel";
            selectTraining_panel.Size = new Size(865, 463);
            selectTraining_panel.TabIndex = 13;
            selectTraining_panel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 101);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "Training details";
            // 
            // loadWorkout_button
            // 
            loadWorkout_button.Location = new Point(296, 51);
            loadWorkout_button.Name = "loadWorkout_button";
            loadWorkout_button.Size = new Size(50, 29);
            loadWorkout_button.TabIndex = 3;
            loadWorkout_button.Text = "Load";
            loadWorkout_button.UseVisualStyleBackColor = true;
            loadWorkout_button.Click += loadWorkout_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Saved trainings";
            // 
            // workout_dataGridView
            // 
            workout_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workout_dataGridView.Location = new Point(41, 124);
            workout_dataGridView.Name = "workout_dataGridView";
            workout_dataGridView.RowHeadersWidth = 51;
            workout_dataGridView.RowTemplate.Height = 29;
            workout_dataGridView.Size = new Size(669, 300);
            workout_dataGridView.TabIndex = 1;
            // 
            // savedTrainings_comboBox
            // 
            savedTrainings_comboBox.FormattingEnabled = true;
            savedTrainings_comboBox.Location = new Point(41, 51);
            savedTrainings_comboBox.Name = "savedTrainings_comboBox";
            savedTrainings_comboBox.Size = new Size(239, 28);
            savedTrainings_comboBox.TabIndex = 0;
            // 
            // addNewExercise_panel
            // 
            addNewExercise_panel.Controls.Add(addNewExercise_checkecComboBox);
            addNewExercise_panel.Controls.Add(logExercise_label);
            addNewExercise_panel.Controls.Add(addNewExercise_label);
            addNewExercise_panel.Controls.Add(newExerciseName_textBox);
            addNewExercise_panel.Controls.Add(addNewExercise2DB_button);
            addNewExercise_panel.Controls.Add(label2);
            addNewExercise_panel.Location = new Point(101, 91);
            addNewExercise_panel.Name = "addNewExercise_panel";
            addNewExercise_panel.Size = new Size(645, 364);
            addNewExercise_panel.TabIndex = 10;
            addNewExercise_panel.Visible = false;
            // 
            // addNewExercise_checkecComboBox
            // 
            addNewExercise_checkecComboBox.FormattingEnabled = true;
            addNewExercise_checkecComboBox.Location = new Point(238, 103);
            addNewExercise_checkecComboBox.Name = "addNewExercise_checkecComboBox";
            addNewExercise_checkecComboBox.Size = new Size(150, 136);
            addNewExercise_checkecComboBox.TabIndex = 11;
            // 
            // logExercise_label
            // 
            logExercise_label.Location = new Point(146, 280);
            logExercise_label.Name = "logExercise_label";
            logExercise_label.Size = new Size(322, 32);
            logExercise_label.TabIndex = 10;
            logExercise_label.Text = "label1";
            logExercise_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addNewExercise_label
            // 
            addNewExercise_label.AutoSize = true;
            addNewExercise_label.Location = new Point(243, 9);
            addNewExercise_label.Name = "addNewExercise_label";
            addNewExercise_label.Size = new Size(125, 20);
            addNewExercise_label.TabIndex = 9;
            addNewExercise_label.Text = "Add new exercise";
            // 
            // newExerciseName_textBox
            // 
            newExerciseName_textBox.Location = new Point(228, 34);
            newExerciseName_textBox.Name = "newExerciseName_textBox";
            newExerciseName_textBox.Size = new Size(182, 27);
            newExerciseName_textBox.TabIndex = 8;
            newExerciseName_textBox.Text = "...";
            // 
            // addNewExercise2DB_button
            // 
            addNewExercise2DB_button.Location = new Point(248, 248);
            addNewExercise2DB_button.Name = "addNewExercise2DB_button";
            addNewExercise2DB_button.Size = new Size(117, 29);
            addNewExercise2DB_button.TabIndex = 7;
            addNewExercise2DB_button.Text = "Add exercise";
            addNewExercise2DB_button.UseVisualStyleBackColor = true;
            addNewExercise2DB_button.Click += addNewExercise2DB_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 80);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 4;
            label2.Text = "Select muscle parts:";
            // 
            // nameTraining_panel
            // 
            nameTraining_panel.Controls.Add(nameTraining_button);
            nameTraining_panel.Controls.Add(trainingName_label);
            nameTraining_panel.Controls.Add(trainingName_textBox);
            nameTraining_panel.Location = new Point(289, 109);
            nameTraining_panel.Name = "nameTraining_panel";
            nameTraining_panel.Size = new Size(250, 145);
            nameTraining_panel.TabIndex = 12;
            nameTraining_panel.Visible = false;
            // 
            // nameTraining_button
            // 
            nameTraining_button.Location = new Point(34, 101);
            nameTraining_button.Name = "nameTraining_button";
            nameTraining_button.Size = new Size(181, 29);
            nameTraining_button.TabIndex = 12;
            nameTraining_button.Text = "Start training";
            nameTraining_button.UseVisualStyleBackColor = true;
            nameTraining_button.Click += nameTraining_button_Click;
            // 
            // trainingName_label
            // 
            trainingName_label.AutoSize = true;
            trainingName_label.Location = new Point(49, 36);
            trainingName_label.Name = "trainingName_label";
            trainingName_label.Size = new Size(137, 20);
            trainingName_label.TabIndex = 11;
            trainingName_label.Text = "Name your training";
            // 
            // trainingName_textBox
            // 
            trainingName_textBox.Location = new Point(34, 61);
            trainingName_textBox.Name = "trainingName_textBox";
            trainingName_textBox.Size = new Size(182, 27);
            trainingName_textBox.TabIndex = 10;
            trainingName_textBox.Text = "...";
            // 
            // addNewExercise_button
            // 
            addNewExercise_button.Location = new Point(334, 71);
            addNewExercise_button.Name = "addNewExercise_button";
            addNewExercise_button.Size = new Size(159, 83);
            addNewExercise_button.TabIndex = 5;
            addNewExercise_button.Text = "Add exercise";
            addNewExercise_button.UseVisualStyleBackColor = true;
            addNewExercise_button.Click += addNewExercise_button_Click;
            // 
            // AddTraining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 656);
            Controls.Add(selectTraining_panel);
            Controls.Add(addNewExercise_button);
            Controls.Add(addNewTraining_button);
            Controls.Add(selectTraining_button);
            Controls.Add(title_label);
            Controls.Add(nameTraining_panel);
            Controls.Add(addNewExercise_panel);
            Controls.Add(addTraining_panel);

            Name = "AddTraining";
            Text = "AddTraining";
            addTraining_panel.ResumeLayout(false);
            addTraining_panel.PerformLayout();
            selectTraining_panel.ResumeLayout(false);
            selectTraining_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workout_dataGridView).EndInit();
            addNewExercise_panel.ResumeLayout(false);
            addNewExercise_panel.PerformLayout();
            nameTraining_panel.ResumeLayout(false);
            nameTraining_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_label;
        private Button selectTraining_button;
        private Button addNewTraining_button;
        private Panel addTraining_panel;
        private Label selectMuscleParts_label;
        private TextBox searchExercise_textBox;
        private ComboBox exercises_comboBox;
        private Button addExercise_button;
        private Button addNewExercise_button;
        private Panel addNewExercise_panel;
        private Label addNewExercise_label;
        private TextBox newExerciseName_textBox;
        private Button addNewExercise2DB_button;
        private Label label2;
        private Label logExercise_label;
        private CheckedListBox addNewExercise_checkecComboBox;
        private Label chooseExercise_label;
        private CheckedListBox muscleParts_comboBox;
        private Panel nameTraining_panel;
        private Label trainingName_label;
        private TextBox trainingName_textBox;
        private Button nameTraining_button;
        private Label check_label;
        private TextBox sets_textBox;
        private TextBox weight_textBox;
        private TextBox reps_textBox;
        private ListBox trainingDetails_listBox;
        private Label kgUnit_label;
        private Label error_label;
        private Label titleTraininig_label;
        private Button saveWorkout_button;
        private Panel selectTraining_panel;
        private Label label1;
        private DataGridView workout_dataGridView;
        private ComboBox savedTrainings_comboBox;
        private Button loadWorkout_button;
        private Label label3;

    }
}