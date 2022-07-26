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

        [HttpGet("admin/Articles/create")]
        public ActionResult CreateArticles()
        {
            return View();
        }

        [HttpPost("admin/articles/create")]
        public async Task<ActionResult> CreateArticlesAsync(SaveArticleViewModel requestVm)
        {
            var mappedOrganizer = _mapper.Map<SaveArticleViewModel, SaveArticle>(requestVm);
            await _articleService.CreateAsync(mappedOrganizer);

            return Redirect("~/admin");
        }

        [HttpPost("Articles/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteArticle(Guid id)
        {
            await _articleService.DeleteAsync(id);

            return Redirect("~/admin");
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

        [HttpGet("admin/Exercises/create")]
        public ActionResult CreateExercises()
        {
            return View();
        }

        [HttpPost("admin/Exercises/create")]
        public async Task<ActionResult> CreateExercisesAsync(ExerciseViewModel requestVm)
        {
            var mappedOrganizer = _mapper.Map<ExerciseViewModel, Exercise>(requestVm);
            await _exerciseService.CreateAsync(mappedOrganizer);

            return Redirect("~/admin");
        }

        [HttpPost("Exercise/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteExercise(Guid id)
        {
            await _exerciseService.DeleteAsync(id);

            return Redirect("~/admin");
        }

        public async Task<ActionResult> ExercisesAsync(int page = 1)
        {
            var result = new AdminExercisesViewModel();

            if (page == 1)
            {
                result.TotalCount = await _exerciseService.GetCountAsync();
            }


            var Exercises = await _exerciseService.GetAllAsync();

            result.Page = page;
            result.Exercises = _mapper.Map<IEnumerable<Exercise>, IEnumerable<ExerciseViewModel>>(Exercises);

            return View(result);
        }

        [HttpGet("admin/SeasonTickets/create")]
        public ActionResult CreateSeasonTickets()
        {
            return View();
        }

        [HttpPost("admin/SeasonTickets/create")]
        public async Task<ActionResult> CreateSeasonTicketsAsync(SeasonTicketTypeViewModel requestVm)
        {
            var mappedOrganizer = _mapper.Map<SeasonTicketTypeViewModel, SeasonTicketType>(requestVm);

            await _seasonTicketTypeService.CreateAsync(mappedOrganizer);

            return Redirect("~/admin");
        }

        [HttpPost("SeasonTickets/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSeasonTickets(Guid id)
        {
            await _seasonTicketTypeService.DeleteAsync(id);

            return Redirect("~/admin");
        }

        public async Task<ActionResult> SeasonTicketsAsync(int page = 1)
        {
            var result = new AdmiSeasonTicketTypeViewModel();

            if (page == 1)
            {
                result.TotalCount = await _seasonTicketTypeService.GetCountAsync();
            }


            var Exercises = await _seasonTicketTypeService.GetAllAsync();

            result.Page = page;
            result.SeasonTicketTypes = _mapper.Map<IEnumerable<SeasonTicketType>, IEnumerable<SeasonTicketTypeViewModel>>(Exercises);

            return View(result);
        }

        [HttpGet("Articles/details/{id}")]
        public async Task<ActionResult> DetailsArticles(Guid id)
        {
            var requestVm = await _seasonTicketTypeService.GetAsync(id);

            var req = _mapper.Map<SeasonTicketType, SeasonTicketTypeViewModel>(requestVm);

            return View(req);
        }


    }

}

