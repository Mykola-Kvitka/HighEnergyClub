using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels
{
    public class TrainerStudentViewModel
    {
        public Guid TrainerId { get; set; }
        public UserViewModel Trainer { get; set; }
        public Guid StudentId { get; set; }
        public UserViewModel Student { get; set; }
    }
}
