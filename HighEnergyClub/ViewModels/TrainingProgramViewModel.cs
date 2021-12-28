using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.ViewModels
{
    public class TrainingProgramViewModel
    { 
        public Guid Id { get; set; }
        public Guid TrainerId { get; set; }
        public string ProgramName { get; set; }
    }
}
