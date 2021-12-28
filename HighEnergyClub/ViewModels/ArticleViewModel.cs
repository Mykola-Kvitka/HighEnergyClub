using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.PL.ViewModels
{
    public class ArticleViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
    }
}
