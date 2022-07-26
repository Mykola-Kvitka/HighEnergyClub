﻿using AutoMapper;
using HighEnergyClub.DAL.Models;
using HighEnergyClub.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighEnergyClub.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<UserEntity> userManager, IMapper mapper,
            SignInManager<UserEntity> signInManager)
        {
            _mapper = mapper;

            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserEntity user = new UserEntity { Email = model.Email, UserName = model.Email };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            UserViewModel userViewModel = _mapper.Map<UserEntity, UserViewModel>(await _userManager.FindByNameAsync(User.Identity.Name)); 

            return View(userViewModel);
        }

        public async Task<ActionResult> EditProfileAsync(UserViewModel requestVm)
        {
            var request = _mapper.Map<UserViewModel, UserEntity>(requestVm);

            var ApUser = await _userManager.FindByIdAsync(request.Id.ToString());

            ApUser.UserName = request.UserName;
            ApUser.Email = request.Email;

            await _userManager.UpdateAsync(ApUser);


            return Redirect("~/Account/Profile");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
