using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class SeasonTicket
    {
        public Guid Id { get; set; }
        public Guid SeasonTicketTypeId { get; set; }
        public string FIO { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
