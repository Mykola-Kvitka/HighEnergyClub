using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class SeasonTicketEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SeasonTicketTypeId { get; set; }
        [MaxLength(128)]
        public string FIO { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
