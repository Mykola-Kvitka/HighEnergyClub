using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.PL.ViewModels
{
    public class SeasonTicketTypeViewModel
    {
        public Guid Id { get; set; }
        public string SeasonTicketTitle { get; set; }
        public string NumbersOfVisits { get; set; }
        public double Cost { get; set; }
        public int Duration { get; set; }
    }
}
