using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class LinkEntity
    {
        [Key]
        public Guid LinkId { get; set; } = Guid.NewGuid();
        public string URL { get; set; }
    }
}
