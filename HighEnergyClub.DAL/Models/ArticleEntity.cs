using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighEnergyClub.DAL.Models
{
    public class ArticleEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
    }
}
