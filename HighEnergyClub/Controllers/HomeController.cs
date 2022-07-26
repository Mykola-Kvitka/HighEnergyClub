using AutoMapper;
using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Models;
using HighEnergyClub.DAL.Models;
using HighEnergyClub.PL.ViewModels;
using HighEnergyClub.PL.ViewModels.Home;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ISeasonTicketTypeService _seasonTicketTypeService;
        private readonly UserManager<UserEntity> _userManager;
                private readonly IMapper _mapper;

        public HomeController(IArticleService articleService, IMapper mapper, ISeasonTicketTypeService seasonTicketTypeService,UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
            _articleService = articleService;
            _mapper = mapper;
            _seasonTicketTypeService = seasonTicketTypeService;

        }

        public async Task<ActionResult> Index()
        {
            var article = await _articleService.GetAllAsync();
            var seasonTicketTypes = await _seasonTicketTypeService.GetAllAsync();
            var coach = await _userManager.GetUsersInRoleAsync("coach");

            HomeViewModel home = new HomeViewModel();

            home.Article = _mapper.Map<IEnumerable<Article>, IEnumerable<ArticleViewModel>>(article);
            home.SeasonTicketType = _mapper.Map<IEnumerable<SeasonTicketType>, IEnumerable<SeasonTicketTypeViewModel>>(seasonTicketTypes);
            home.Users = _mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(coach);

            return View(home);
        }
        public IActionResult AboutUS()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }

        public async Task<ActionResult> ClubCard()
        {
            var seasonTicketTypes = await _seasonTicketTypeService.GetAllAsync();

            return View(_mapper.Map<IEnumerable<SeasonTicketType>, IEnumerable<SeasonTicketTypeViewModel>>(seasonTicketTypes));
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
