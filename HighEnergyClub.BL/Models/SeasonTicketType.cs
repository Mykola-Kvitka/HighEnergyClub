using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class SeasonTicketType
    {
        public Guid Id { get; set; }
        public string SeasonTicketTitle { get; set; }
        public string NumbersOfVisits { get; set; }
        public double Cost { get; set; }
        public int Duration { get; set; }
    }
}
