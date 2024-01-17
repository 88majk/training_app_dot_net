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
        private string[] newColumnNames = { "Exercise", "Sets", "Reps", "Weight [kg]" };

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
        private int userId;
        DateTime todaysDate;


        public AddTraining(DateTime selectedDate, int id)
        {
            userId = id;
            todaysDate = selectedDate;
            InitializeComponent();
            _dbContext = new DBContext();
            _catalogExerciseService = new Database.Services.CatalogExerciseService(new DBContext());
            _trainingService = new Database.Services.TrainingService(new DBContext());
            _EITService = new Database.Services.ExercisesInTrainingService(new DBContext());

            currExercises_dataGridView.CellClick += currExercises_dataGridView_CellClick;
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

        ////////////////////////////////////////////////////////
        //////// OBSLUGA DODAWANIA NOWEGO TRENINGU /////////////
        ////////////////////////////////////////////////////////


        // Obsługa okienka - nazwanie treningu i wygenerowanie jego ID
        private void nameTraining_button_Click(object sender, EventArgs e)
        {
            int trainingID = _trainingService.GetTrainingIdByName(trainingName_textBox.Text);
            if (_trainingService.DoesTrainingExists(trainingName_textBox.Text))
            {
                DialogResult result = MessageBox.Show("Czy chcesz edytować ten trening?", "Podany trening już istnieje.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    addTraining_panel.Visible = true;
                    nameTraining_panel.Visible = false;

                    List<ExercisesInTraining> exercisesInTraining = _EITService.GetAllExercisesInTraining(trainingID);

                    List<ExercisesInTrainingDisplay> displayList =
                    exercisesInTraining.Select(exercise => new ExercisesInTrainingDisplay
                    {
                        ExerciseName = _dbContext.CatalogExercises.FirstOrDefault(c => c.Id == exercise.ExerciseId)?.Name,
                        Sets = exercise.Sets,
                        Reps = exercise.Reps,
                        Weight = exercise.Weight
                    })
                .ToList();

                    currExercises_dataGridView.DataSource = displayList;
                    for (int i = 0; i < workout_dataGridView.Columns.Count && i < newColumnNames.Length; i++)
                    {
                        workout_dataGridView.Columns[i].HeaderText = newColumnNames[i];
                    }
                }
                check_label.Text = trainingName_textBox.Text;
            }
            else
            {
                Training trainingToAdd = new Training
                {
                    User_ID = userId,
                    Name = trainingName_textBox.Text,
                    Date = todaysDate
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
                ExercisesInTraining exerciseInTraining = new ExercisesInTraining
                {
                    TrainingId = _trainingService.GetTrainingIdByName(check_label.Text),
                    ExerciseId = _EITService.GetExerciseIdByName(returnExerciseName()),
                    Sets = int.Parse(sets_textBox.Text),
                    Reps = int.Parse(reps_textBox.Text),
                    Weight = int.Parse(weight_textBox.Text)
                };
                int workoutId = _EITService.SaveWorkout(exerciseInTraining);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                error_label.Text = ex.Message;
            }

            List<ExercisesInTraining> exercisesInTraining = _EITService.GetAllExercisesInTraining(_trainingService.GetTrainingIdByName(check_label.Text));

            List<ExercisesInTrainingDisplay> displayList =
                    exercisesInTraining.Select(exercise => new ExercisesInTrainingDisplay
                    {
                        ExerciseName = _dbContext.CatalogExercises.FirstOrDefault(c => c.Id == exercise.ExerciseId)?.Name,
                        Sets = exercise.Sets,
                        Reps = exercise.Reps,
                        Weight = exercise.Weight
                    })
                .ToList();

            currExercises_dataGridView.DataSource = displayList;
            for (int i = 0; i < workout_dataGridView.Columns.Count && i < newColumnNames.Length; i++)
            {
                workout_dataGridView.Columns[i].HeaderText = newColumnNames[i];
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

        // USUWANIE CWICZENIA Z GRIDVIEW
        private List<ExercisesInTraining> records = new List<ExercisesInTraining>();

        private void currExercises_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currExercises_dataGridView.SelectedRows.Count >= 0)
            {
                int selectedRowIndex = currExercises_dataGridView.SelectedRows[0].Index;
                ExercisesInTrainingDisplay selectedRecord = (ExercisesInTrainingDisplay)currExercises_dataGridView.Rows[selectedRowIndex].DataBoundItem;

                int exerciseIdToDelete = _EITService.GetExerciseIdByName(selectedRecord.ExerciseName);
                int trainingId = _trainingService.GetTrainingIdByName(check_label.Text);

                _EITService.DeleteExerciseFromTraining(trainingId, exerciseIdToDelete);


                List<ExercisesInTraining> exercisesInTraining = _EITService.GetAllExercisesInTraining(trainingId);

                List<ExercisesInTrainingDisplay> displayList =
                    exercisesInTraining.Select(exercise => new ExercisesInTrainingDisplay
                    {
                        ExerciseName = _dbContext.CatalogExercises.FirstOrDefault(c => c.Id == exercise.ExerciseId)?.Name,
                        Sets = exercise.Sets,
                        Reps = exercise.Reps,
                        Weight = exercise.Weight
                    })
                    .ToList();

                currExercises_dataGridView.DataSource = displayList;
            }
        }

        private void currExercises_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && currExercises_dataGridView.Columns[e.ColumnIndex].ReadOnly == false)
            {
                currExercises_dataGridView.BeginEdit(true);
            }
        }

        // EDYCJA WARTOSCI W GRIDVIEW
        private void currExercises_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                object editedValue = currExercises_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int exerciseId =_EITService.GetExerciseIdByName(currExercises_dataGridView.Rows[e.RowIndex].Cells["ExerciseName"].Value.ToString());
                int sets =_EITService.GetExerciseIdByName(currExercises_dataGridView.Rows[e.RowIndex].Cells["Sets"].Value.ToString());
                int reps =_EITService.GetExerciseIdByName(currExercises_dataGridView.Rows[e.RowIndex].Cells["Reps"].Value.ToString());
                int trainingId = _trainingService.GetTrainingIdByName(check_label.Text);

                var recordToUpdate = _dbContext.Workouts
                    .FirstOrDefault(w => w.ExerciseId == exerciseId && w.TrainingId == trainingId && w.Sets == sets && w.Reps == reps);

                if (recordToUpdate != null)
                {
                    string columnName = currExercises_dataGridView.Columns[e.ColumnIndex].Name;

                    switch (columnName)
                    {
                        case "Sets":
                            if (editedValue is int intValue1)
                            {
                                recordToUpdate.Sets = intValue1;
                            }
                            break;

                        case "Reps":
                            if (editedValue is int intValue2)
                            {
                                recordToUpdate.Reps = intValue2;
                            }
                            break;

                        case "Weight":
                            if (editedValue is float floatValue3)
                            {
                                recordToUpdate.Weight = floatValue3;
                            }
                            break;
                        default:

                            break;
                    }
                    _dbContext.SaveChanges();
                }
            }
        }

        private void exercises_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> selectedMuscleParts = new List<string>();
            if (muscleParts_comboBox.CheckedItems.Count > 0 && (searchExercise_textBox.Text == "Search exercise..." || searchExercise_textBox.Text == ""))
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
            else if (searchExercise_textBox.Text != "Search exercise...")
            {
                List<CatalogExercise> exercises = _catalogExerciseService.GetExercisesBySearch(searchExercise_textBox.Text);

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


        ///// OBLUSGA PRZYCISKU SELECT TRAINING
        private void selectTraining_button_Click(object sender, EventArgs e)
        {
            hideActionTypeButtons();
            selectTraining_panel.Visible = true;

            List<Training> trainings = _trainingService.GetTrainingsFromDatabase(userId);

            foreach (var item in trainings)
            {
                savedTrainings_comboBox.Items.Add(item.ToString());
            }
        }

        private void loadWorkout_button_Click(object sender, EventArgs e)
        {
            if (savedTrainings_comboBox.SelectedItem != null)
            {
                int trainingID = _trainingService.GetTrainingIdByName(savedTrainings_comboBox.SelectedItem.ToString());
                List<ExercisesInTraining> workout = _EITService.GetAllExercisesInTraining(trainingID);

                List<ExercisesInTrainingDisplay> displayList =
                    workout.Select(exercise => new ExercisesInTrainingDisplay
                    {
                        ExerciseName = _dbContext.CatalogExercises.FirstOrDefault(c => c.Id == exercise.ExerciseId)?.Name,
                        Sets = exercise.Sets,
                        Reps = exercise.Reps,
                        Weight = exercise.Weight
                    })
                .ToList();

                workout_dataGridView.DataSource = displayList;
                for (int i = 0; i < workout_dataGridView.Columns.Count && i < newColumnNames.Length; i++)
                {
                    workout_dataGridView.Columns[i].HeaderText = newColumnNames[i];
                }
            }
        }

        private void saveAsDone_button_Click(object sender, EventArgs e)
        {
            int real_trainingId = _trainingService.GetTrainingIdByName(savedTrainings_comboBox.SelectedItem.ToString());

            Training trainingToAdd = new Training
            {
                User_ID = userId,
                Name = savedTrainings_comboBox.SelectedItem.ToString(),
                Date = todaysDate
            };
            int trainingId = _trainingService.AddTrainingToDatabase(trainingToAdd);
            List<ExercisesInTraining> workouts = _EITService.GetAllExercisesInTraining(real_trainingId);
            foreach (var item in workouts)
            {
                int workoutId = _EITService.SaveWorkout(item);
            }

            inform_label.Text = $"Good job! Workout with id {trainingId} added to history";
        }
    }
}
