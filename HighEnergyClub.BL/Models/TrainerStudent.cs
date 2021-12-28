using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.BL.Models
{
    public class TrainerStudent
    {
        public Guid TrainerId { get; set; }
        public User Trainer { get; set; }
        public Guid StudentId { get; set; }
        public User Student { get; set; }
    }
}
