using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels.Admin
{
    public class AdminArticlesViewModel : PagedViewModel
    {
        public IEnumerable<ArticleViewModel> Articles { get; set; }

    }
}
