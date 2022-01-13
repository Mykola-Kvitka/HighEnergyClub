using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public string URL { get; set; }
    }
}
