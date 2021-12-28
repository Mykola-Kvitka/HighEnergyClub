using System;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.PL.ViewModels
{
    public class LinkViewModel
    {
        public Guid LinkId { get; set; }
        public string URL { get; set; }
    }
}
