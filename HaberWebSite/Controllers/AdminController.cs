using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HaberWebSite.Models;
using HaberWebSite.Models.EfCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HaberWebSite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IPasswordHasher<ApplicationUser> passwordHasher;
        private IPasswordValidator<ApplicationUser> passwordValidator;
        public AdminController(UserManager<ApplicationUser> _userManager, IPasswordHasher<ApplicationUser> _passwordHasher, IPasswordValidator<ApplicationUser> _passwordValidator)
        {
            userManager = _userManager;
            passwordHasher = _passwordHasher;
            passwordValidator = _passwordValidator;

        }

        public IActionResult Index()
        {

            return View(userManager.Users);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            ApplicationUser user = new ApplicationUser();
            if (user != null)
            {
                user.UserName = model.UserName;
                user.Email = model.Email;
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return Redirect("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Uptade(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Update(string Id, string Password,string Email)
        {
            var user = await userManager.FindByIdAsync(Id);
            if(user != null)
            {
                user.Email = Email;
                IdentityResult identityResult = null;
                if(!string.IsNullOrEmpty(Password))
                {
                    identityResult = await passwordValidator.ValidateAsync(userManager, user, Password);
                    if (identityResult.Succeeded)
                    {
                        user.PasswordHash =  passwordHasher.HashPassword(user, Password);
                    }
                    else
                    {
                        foreach (var item in identityResult.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }


                }

                if (identityResult.Succeeded)
                {
                        var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                
               
               
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View(user);
        }
  

    }
}