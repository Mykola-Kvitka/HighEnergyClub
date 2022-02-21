using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace HighEnergyClub.BL.Models
{
    public class UpdateArticle
    {
        public Guid Id;
        public string Title { get; set; }
        public string Text { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}
