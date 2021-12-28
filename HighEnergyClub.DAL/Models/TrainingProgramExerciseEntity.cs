using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class TrainingProgramExerciseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid TrainingProgramID { get; set; }
        public Guid ExerciseEntityID { get; set; }
        [MaxLength(64)]
        public string NumberRepitions { get; set; }
        [MaxLength(64)]
        public string Approaches { get; set; }
        [MaxLength(64)]
        public string Weight { get; set; }
    }
}
