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

        private void muscleParts_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValues1.Clear();

            foreach (object item in muscleParts_comboBox.CheckedItems)
            {
                selectedValues1.Add(item.ToString());
            }

            var query = _dbContext.CatalogExercises.AsQueryable();


            foreach (string sv in selectedValues1)
            {
                string temp = sv;
                query = query.Where(e => e.MuscleParts.Contains(sv));
            }


            var exercises = query
                .OrderBy(e => e.Name)
                .Select(e => $"{e.Name} - {e.MuscleParts}")
                .ToList();



            exercises_comboBox.Items.Clear();

            exercises_comboBox.Items.AddRange(exercises.ToArray());
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
                CatalogExercise exerciseToAdd = new CatalogExercise
                {
                    Name = newExerciseName,
                    MuscleParts = concatenatedValues
                };

                int idExercise = _catalogExerciseService.AddExerciseToDatabase(exerciseToAdd);
                logExercise_label.Text = $"Exercise with id = {idExercise} successfully added";
            }
        }

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
                check_label.Text = "Pomyslnie dodano trening do bazy";
            }
        }

        public void AddExercisesToTraining(int trainingId, List<int> exerciseIds, List<int> sets, List<int> reps, List<int> weights)
        {
            if (exerciseIds.Count != sets.Count || sets.Count != reps.Count || reps.Count != weights.Count)
            {
                // Błąd - ilość elementów w listach musi być taka sama
                return;
            }

            for (int i = 0; i < exerciseIds.Count; i++)
            {
                var exerciseInTraining = new ExercisesInTraining
                {
                    TrainingId = trainingId,
                    ExerciseId = exerciseIds[i],
                    Sets = sets[i],
                    Reps = reps[i],
                    Weight = weights[i]
                };

                // Dodaj rekord do bazy danych
                int ide = _EITService;
            }

            // Zapisz zmiany w bazie danych
            _dbContext.SaveChanges();
        }
    }
}
