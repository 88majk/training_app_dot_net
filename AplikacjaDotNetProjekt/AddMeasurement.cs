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
using Microsoft.VisualBasic.ApplicationServices;

namespace AplikacjaDotNetProjekt
{
    public partial class AddMeasurement : Form
    {
        private int userID;
        private DBContext _dbContext;
        private string[] newColumnNames = { "Date", "Weight [kg]", "Height [cm]", "Arm circuit [cm]", "Chest circuit [cm]" };

        private MeasurementHistoryService _service;

        public AddMeasurement(int userId)
        {
            InitializeComponent();
            userID = userId;
            _dbContext = new DBContext();
            _service = new MeasurementHistoryService(new DBContext());

            List<MeasurementHistoryDisplay> displayList = _service.GetMeasurementHistory(userId)
                .Select(measurement => new MeasurementHistoryDisplay
                {
                    Date = measurement.Date,
                    userHeight = measurement.userHeight,
                    userWeight = measurement.userWeight,
                    armCircuit = measurement.armCircuit,
                    chestCircuit = measurement.chestCircuit
                }).ToList();
            measurementsHistory_dataGridView.DataSource = displayList;

            for (int i = 0; i < measurementsHistory_dataGridView.Columns.Count && i < newColumnNames.Length; i++)
            {
                measurementsHistory_dataGridView.Columns[i].HeaderText = newColumnNames[i];
            }
        }

        private void saveMeasurement_button_Click(object sender, EventArgs e)
        {
            //dodanie bledu o typie zmiennej

            MeasurementHistory newMeasurement = new MeasurementHistory
            {
                userId = userID,
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                userHeight = float.Parse(height_textBox.Text),
                userWeight = float.Parse(weight_textBox.Text),
                armCircuit  = float.Parse(armCircuit_textBox.Text),
                chestCircuit = float.Parse(chestCircuit_textBox.Text)
            };
            int measurementId = _service.AddMeasurementToDatabase(newMeasurement);
            error_label.Text = $"Measurement {measurementId} succesfully added";


            List<MeasurementHistoryDisplay> displayList = _service.GetMeasurementHistory(userID)
                .Select(measurement => new MeasurementHistoryDisplay
                {
                    Date = measurement.Date,
                    userHeight = measurement.userHeight,
                    userWeight = measurement.userWeight,
                    armCircuit = measurement.armCircuit,
                    chestCircuit = measurement.chestCircuit
                }).ToList();
            measurementsHistory_dataGridView.DataSource = displayList;

            for (int i = 0; i < measurementsHistory_dataGridView.Columns.Count && i < newColumnNames.Length; i++)
            {
                measurementsHistory_dataGridView.Columns[i].HeaderText = newColumnNames[i];
            }
        }
    }
}
