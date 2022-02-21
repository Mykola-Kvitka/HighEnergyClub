using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.PL.ViewModels
{
    public class ImageViewModel
    {
        public Guid ImageId { get; set; }
        public string ImagePath { get; set; }
    }
}
