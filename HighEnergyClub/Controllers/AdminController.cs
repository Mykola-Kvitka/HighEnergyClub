using AutoMapper;
using HighEnergyClub.BL.Interfaces;
using HighEnergyClub.BL.Models;
using HighEnergyClub.PL.ViewModels;
using HighEnergyClub.PL.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.Controllers
{
    public class AdminController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IExerciseService _exerciseService;
        private readonly ISeasonTicketTypeService _seasonTicketTypeService;
        private readonly IMapper _mapper;

        public AdminController(
            IArticleService activityService,
            IMapper mapper,
            IExerciseService exerciseService,
            ISeasonTicketTypeService seasonTicketTypeService )
        {
            _articleService = activityService;
            _mapper = mapper;
            _exerciseService = exerciseService;
            _seasonTicketTypeService = seasonTicketTypeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ArticlesAsync(int page = 1)
        {
            var result = new AdminArticlesViewModel();

            if (page == 1)
            {
                result.TotalCount = await _articleService.GetCountAsync();
            }


            var Article = await _articleService.GetAllAsync();

            result.Page = page;
            result.Articles = _mapper.Map<IEnumerable<Article>, IEnumerable<ArticleViewModel>>(Article);

            return View(result);
        }
    }

}

