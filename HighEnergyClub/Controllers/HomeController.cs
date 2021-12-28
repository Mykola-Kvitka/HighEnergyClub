using HighEnergyClub.BL.Models;
using HighEnergyClub.BL.Services;
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
        private readonly ArticleService _articleService;

        public HomeController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<ActionResult> CreateAsync()
        {
            var viewModel = new SaveArticleViewModel();

            return View(viewModel);
        }

        [HttpPost("home/create")]
        public async Task<ActionResult> CreateActivityAsync(SaveArticleViewModel requestVm)
        {

            await _articleService.CreateAsync(new SaveArticle() { Images = requestVm.Images, Text = requestVm.Text, Title = requestVm.Title });
            return Redirect("~/home");

        }
    }
}
