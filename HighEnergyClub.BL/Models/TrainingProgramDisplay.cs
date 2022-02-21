using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Models
{
    public class TrainingProgramDisplay
    {
        public Guid Id { get; set; }
        public Guid TrainerId { get; set; }
        public Guid UserId { get; set; }
        public string ProgramName { get; set; }
        public List<TrainingProgramExercise> trainingProgramExercises { get; set; }
    }
}
