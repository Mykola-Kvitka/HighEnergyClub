﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels.Admin
{
    public class AdmiSeasonTicketTypeViewModel : PagedViewModel
    {
        public IEnumerable<SeasonTicketTypeViewModel> SeasonTicketTypes { get; set; }

    }
}
