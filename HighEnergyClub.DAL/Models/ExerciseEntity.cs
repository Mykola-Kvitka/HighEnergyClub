using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class ExerciseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(64)]
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public Guid VideoLinkHowToDo { get; set; }
    }
}
