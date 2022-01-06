using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.PL.ViewModels
{
    public class ExerciseViewModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(64)]
        public string ExerciseName { get; set; }
        public LinkViewModel VideoLinkHowToDo { get; set; }
    }
}
