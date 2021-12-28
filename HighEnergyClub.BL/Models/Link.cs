using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class Link
    {
        public Guid LinkId { get; set; }
        public string URL { get; set; }
    }
}
