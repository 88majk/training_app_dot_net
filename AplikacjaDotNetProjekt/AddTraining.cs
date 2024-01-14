using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using addTrainingLibrary;
using System.Data.SqlClient;

namespace AplikacjaDotNetProjekt
{
    public partial class AddTraining : Form
    {
        List<string> muscleGroups = new List<string> { "Chest", "Back", "Shoudlers",
            "Triceps", "Biceps", "Forearms", "Thighs and buttocks", "Abdomen", "Calves", "Cardio"};
        List<string> chestExercises = new List<string> { "Push-Up", "Dips", "Bench Press"};
        List<string> backExercises = new List<string> { "Pull-Ups", "Cable Rows", "Rear Deltoids"};
        List<string> tricepsExercises = new List<string> { "Push-Ups", "Tricep Push", "Dumbbell Kicks"};

        public AddTraining()
        {
            InitializeComponent();
        }

        private void addNewTraining_button_Click(object sender, EventArgs e)
        {
            hideActionTypeButtons();
            foreach (string part in muscleGroups)
            {
                muscleParts_comboBox.Items.Add(part);
            }
            muscleParts_comboBox.SelectedIndexChanged += muscleParts_comboBox_SelectedIndexChanged;
            addTraining_panel.Visible = true;
        }

        private void muscleParts_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSource = muscleParts_comboBox.SelectedIndex.ToString();

            switch(selectedSource)
            {
                case "0":
                    exercises_comboBox.Items.Clear();
                    foreach (string exercise in chestExercises)
                    {
                        exercises_comboBox.Items.Add(exercise);
                    }
                    break;
                case "1":
                    exercises_comboBox.Items.Clear();
                    foreach (string exercise in backExercises)
                    {
                        exercises_comboBox.Items.Add(exercise);
                    }
                    break;
                case "3":
                    exercises_comboBox.Items.Clear();
                    foreach (string exercise in tricepsExercises)
                    {
                        exercises_comboBox.Items.Add(exercise);
                    }
                    break;
            }
        }

        private void hideActionTypeButtons()
        {
            addNewTraining_button.Visible = false;
            selectTraining_button.Visible = false;
        }
    }
}
