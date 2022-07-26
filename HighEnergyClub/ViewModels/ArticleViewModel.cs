using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.PL.ViewModels
{
    public class ArticleViewModel
    {
        public Guid Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
        public IEnumerable<ImageViewModel> Images { get; set; }

    }
}
