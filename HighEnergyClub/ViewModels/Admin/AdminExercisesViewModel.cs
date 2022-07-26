using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels.Admin
{
    public class AdminExercisesViewModel : PagedViewModel
    {
        public IEnumerable<ExerciseViewModel> Exercises { get; set; }

    }
}
