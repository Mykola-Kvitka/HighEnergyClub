using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.BL.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
