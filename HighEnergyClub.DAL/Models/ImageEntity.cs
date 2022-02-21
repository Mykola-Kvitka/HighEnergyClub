using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class ImageEntity
    {
        [Key]
        public Guid ImageId { get; set; } = Guid.NewGuid();
        [MaxLength(2000)]
        public string ImagePath{ get; set; }
    }
}
