using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public string ImagePath { get; set; }
    }
}
