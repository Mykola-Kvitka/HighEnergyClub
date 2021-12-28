using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class TrainingProgramExercise
    {
        public Guid Id { get; set; }
        public Guid TrainingProgramID { get; set; }
        public Guid ExerciseEntityID { get; set; }
        public string NumberRepitions { get; set; }
        public string Approaches { get; set; }
        public string Weight { get; set; }
    }
}
