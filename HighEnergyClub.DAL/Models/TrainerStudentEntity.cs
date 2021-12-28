using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.DAL.Models
{
    public class TrainerStudentEntity
    {
        public Guid TrainerId { get; set; }
        public Guid StudentId { get; set; }
    }
}
