using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class SeasonTicketTypeEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(128)]
        public string SeasonTicketTitle { get; set; }
        [MaxLength(128)]
        public string NumbersOfVisits { get; set; }
        public double Cost { get; set; }
        public int Duration { get; set; }
    }
}
