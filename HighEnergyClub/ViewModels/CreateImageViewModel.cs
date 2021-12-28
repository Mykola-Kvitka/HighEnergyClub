using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels
{
    public class CreateImageViewModel
    {
        public IFormFile Image { get; set; }
    }
}
