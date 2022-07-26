using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels.Home
{
    public class HomeViewModel
    {
        public IEnumerable<ArticleViewModel> Article { get; set; }
        public IEnumerable<SeasonTicketTypeViewModel> SeasonTicketType { get; set; }
        public IEnumerable<UserViewModel> Users { get; set; }

    }
}
