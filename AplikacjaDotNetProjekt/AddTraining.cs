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
using AplikacjaDotNetProjekt.Database.Models;
using AddProductLibrary;
using AplikacjaDotNetProjekt.Database.Services;
using AplikacjaDotNetProjekt.Database;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace AplikacjaDotNetProjekt
{
    public partial class AddTraining : Form
    {
        List<string> muscleGroups = new List<string> { "Chest", "Back", "Shoulders",
            "Triceps", "Biceps", "Forearms", "Thighs and buttocks", "Abdomen", "Calves", "Cardio"};
        List<string> selectedValues = new List<string>();
        List<string> selectedValues1 = new List<string>();

        List<int> exerciseId = new List<int>();
        List<string> exerciseName = new List<string>();
        List<int> sets = new List<int>();
        List<int> reps = new List<int>();
        List<float> weight = new List<float>();

        private Database.Services.CatalogExerciseService _catalogExerciseService;
        private Database.Services.TrainingService _trainingService;
        private Database.Services.ExercisesInTrainingService _EITService;
        private DBContext _dbContext;

        string concatenatedValues;

        public AddTraining()
        {
            InitializeComponent();
            _dbContext = new DBContext();
            _catalogExerciseService = new Database.Services.CatalogExerciseService(new DBContext());
            _trainingService = new Database.Services.TrainingService(new DBContext());
            _EITService = new Database.Services.ExercisesInTrainingService(new DBContext());
        }

        private void addNewTraining_button_Click(object sender, EventArgs e)
        {
            hideActionTypeButtons();

            foreach (string part in muscleGroups)
            {
                muscleParts_comboBox.Items.Add(part);
            }

            nameTraining_panel.Visible = true;

        }

        // Wypełnienie ComboBoxa ćwiczeniami z bazy danych
        private void muscleParts_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void hideActionTypeButtons()
        {
            addNewTraining_button.Visible = false;
            addNewExercise_button.Visible = false;
            selectTraining_button.Visible = false;
        }

        private void addNewExercise_button_Click(object sender, EventArgs e)
        {
            hideActionTypeButtons();
            addNewExercise_panel.Visible = true;

            foreach (string part in muscleGroups)
            {
                addNewExercise_checkecComboBox.Items.Add(part);
            }
            addNewExercise_checkecComboBox.SelectedIndexChanged += addExmuscleParts_comboBox_SelectedIndexChanged;
        }

        private void addExmuscleParts_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSource = addNewExercise_checkecComboBox.SelectedIndex.ToString();

            switch (selectedSource)
            {

            }
        }

        // Dodawanie nowego ćwiczenia do bazy
        private void addNewExercise2DB_button_Click(object sender, EventArgs e)
        {
            string newExerciseName = newExerciseName_textBox.Text;
            selectedValues.Clear();

            foreach (object item in addNewExercise_checkecComboBox.CheckedItems)
            {
                selectedValues.Add(item.ToString());
            }

            string concatenatedValues = string.Join(",", selectedValues);

            if (_catalogExerciseService.DoesExerciseExists(newExerciseName))
            {
                logExercise_label.Text = $"Exericise with name {newExerciseName} already exists.";
            }
            else
            {
                if (selectedValues.Any())
                {
                    CatalogExercise exerciseToAdd = new CatalogExercise
                    {
                        Name = newExerciseName,
                        MuscleParts = concatenatedValues
                    };
                    int idExercise = _catalogExerciseService.AddExerciseToDatabase(exerciseToAdd);
                    logExercise_label.Text = $"Exercise with id = {idExercise} successfully added";
                }
                else
                {
                    logExercise_label.Text = "Please select muscle parts.";
                }
            }
        }


        // Obsługa okienka - nazwanie treningu i wygenerowanie jego ID
        private void nameTraining_button_Click(object sender, EventArgs e)
        {

            if (_trainingService.DoesTrainingExists(trainingName_textBox.Text))
            {
                trainingName_textBox.Text = "Podany trening już istnieje w bazie";
            }
            else
            {
                Training trainingToAdd = new Training
                {
                    Name = trainingName_textBox.Text,
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };
                addTraining_panel.Visible = true;
                nameTraining_panel.Visible = false;
                int trainingId = _trainingService.AddTrainingToDatabase(trainingToAdd);
                check_label.Text = trainingName_textBox.Text;
            }
        }


        // Zapisywanie kolejnych ćwiczeń treningu
        private void addExercise_button_Click(object sender, EventArgs e)
        {
            try
            {
                exerciseName.Add(returnExerciseName());
                exerciseId.Add(_EITService.GetExerciseIdByName(returnExerciseName()));
                sets.Add(int.Parse(sets_textBox.Text));
                reps.Add(int.Parse(reps_textBox.Text));
                weight.Add(int.Parse(weight_textBox.Text));
                addDetailsToListBox(exerciseId, exerciseName, sets, reps, weight);
            }
            catch (Exception ex)
            {
                error_label.Text = ex.Message;
            }
        }

        private void addDetailsToListBox(List<int> exerciseId, List<string> exerciseName, List<int> sets, List<int> reps, List<float> weight)
        {
            trainingDetails_listBox.Items.Clear();

            for (int i = 0; i < sets.Count; i++)
            {
                trainingDetails_listBox.Items.Add($"{exerciseName[i]} - Sets: {sets[i]} - reps: {reps[i]} - weight: {weight[i]} kg");
            }
        }

        // Funkcja pobierająca tylko nazwe ćwiczenia z comboBox
        private string returnExerciseName()
        {
            string selectedExercise = exercises_comboBox.SelectedItem.ToString();

            int index = selectedExercise.IndexOf(":");

            if (index >= 0)
            {
                return selectedExercise.Substring(0, index);
            }

            return selectedExercise;

        }

        // Zapisanie treningu całego do bazy danych
        private void saveWorkout_button_Click(object sender, EventArgs e)
        {
            int trainingId = _trainingService.GetTrainingIdByName(check_label.Text);
            AddExercisesToTraining(trainingId, exerciseId, sets, reps, weight);
        }

        // Funkcja do zapisu całego treningu do bazy danych
        public void AddExercisesToTraining(int trainingId, List<int> exerciseIds, List<int> sets, List<int> reps, List<float> weights)
        {
            if (exerciseIds.Count != sets.Count || sets.Count != reps.Count || reps.Count != weights.Count)
            {
                return;
            }

            for (int i = 0; i < exerciseId.Count; i++)
            {
                ExercisesInTraining exerciseInTraining = new ExercisesInTraining
                {
                    TrainingId = trainingId,
                    ExerciseId = exerciseIds[i],
                    Sets = sets[i],
                    Reps = reps[i],
                    Weight = weights[i]
                };

                int workoutId = _EITService.SaveWorkout(exerciseInTraining);
            }
            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {

            }
        }

        private void exercises_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> selectedMuscleParts = new List<string>();
            if (muscleParts_comboBox.CheckedItems.Count > 0)
            {
                foreach (object item in muscleParts_comboBox.CheckedItems)
                {
                    selectedMuscleParts.Add(item.ToString());
                }
                List<CatalogExercise> exercises = _catalogExerciseService.GetExercisesByMuscleParts(selectedMuscleParts);

                exercises_comboBox.Items.Clear();

                foreach (var exercise in exercises)
                {
                    exercises_comboBox.Items.Add(exercise.ToString());
                }
            }
            else 
            {
                List<CatalogExercise> allExercises = _dbContext.GetExercisesFromDB();
                foreach (var exercise in allExercises)
                {
                    exercises_comboBox.Items.Add(exercise.ToString());
                }
            }
            
        }
    }
}
