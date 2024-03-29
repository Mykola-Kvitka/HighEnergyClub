﻿using HighEnergyClub.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.ViewModels.Admin
{
    public class AdminRolesViewModel : PagedViewModel
    {
        public IEnumerable<RoleEntity> Roles { get; set; }
    }
}
