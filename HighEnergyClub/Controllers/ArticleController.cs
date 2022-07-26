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
    [Route("article")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(
            IArticleService activityService,
            IMapper mapper)
        {
            _articleService = activityService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var activity = await _articleService.GetAsync(id);
            var viewActivity = _mapper.Map<Article, ArticleViewModel>(activity);
            return View(viewActivity);
        }
    }
}
