using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class ExercisesInTraining
    {
        public int Id { get; set; }
        public int TrainingId { get; set; } //jako klucz obcy do tabeli Training
        public int ExerciseId { get; set; } //jako klucz obcy do tabeli CatalogExercise
        public int Sets { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }
    }
}
