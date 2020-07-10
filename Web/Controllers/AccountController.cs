using System;
using System.Threading.Tasks;
using Application.Service;
using Domain;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        public AccountController(IUserService userService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    { return Redirect(returnUrl ?? "/"); }
                }
                ModelState.AddModelError(nameof(model.Email), "ایمیل یا گذرواژه نادرست است");
            }
            return View(model);
        }
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email, 
                    DisplayName = model.Name,
                    CreationDateTime = DateTime.Now
                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("/");
                }
                else
                {
                    foreach (IdentityError error in result.Errors) { ModelState.AddModelError("", error.Description); }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                return View(user);
            }
            else
            { return RedirectToAction("Index"); }
        }
        // [HttpPost]
        // public async Task<IActionResult> Edit(string id, string email, string password)
        // {
        //     return View();
        // }

        public IActionResult NotAllowing()
        {
            return View();
        }



    }
}