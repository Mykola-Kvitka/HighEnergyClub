using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels
{
    public class SaveArticleViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}
