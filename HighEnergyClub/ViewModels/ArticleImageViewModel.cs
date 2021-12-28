using System;

namespace HighEnergyClub.PL.Models
{
    public class ArticleImageViewModel
    {
        public Guid ArticleId { get; set; }
        public ArticleViewModel Article { get; set; }
        public Guid ImageId { get; set; }
        public ImageViewModel Image { get; set; }
    }
}
