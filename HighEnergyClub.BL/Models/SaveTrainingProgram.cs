using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Models
{
    public class SaveTrainingProgram
    {
        public Guid TrainerId { get; set; }
        public string ProgramName { get; set; }
        public List<Guid> ExerciseEntityID { get; set; }
        public string NumberRepitions { get; set; }
        public string Approaches { get; set; }
        public string Weight { get; set; }
    }
}
