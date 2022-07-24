using AutoMapper;
using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Models;
using HighEnergyClub.PL.ViewModels;
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
        private readonly IMapper _mapper;

        public HomeController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public async Task<ActionResult> Index()
        {
            //var article = await _articleService.GetAllAsync();

            //return View(_mapper.Map<IEnumerable<Article>, IEnumerable<ArticleViewModel>>(article));
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult ClubCard()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
