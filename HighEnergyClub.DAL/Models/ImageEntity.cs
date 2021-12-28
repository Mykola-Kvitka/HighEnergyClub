using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class ImageEntity
    {
        [Key]
        [MaxLength(2000)]
        public string ImagePathId { get; set; }
    }
}
