using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class TrainingProgram
    { 
        public Guid Id { get; set; }
        public Guid TrainerId { get; set; }
        public string ProgramName { get; set; }
    }
}
