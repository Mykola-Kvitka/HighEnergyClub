using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class TrainingProgramEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid TrainerId { get; set; }
        [MaxLength(64)]
        public string ProgramName { get; set; }
    }
}
