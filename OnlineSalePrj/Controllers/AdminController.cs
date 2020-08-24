using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineSalePrj.Models;
using OnlineSalePrj.ViewModel;

namespace OnlineSalePrj.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AdminController(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            ViewBag.Roles = new String[] { "Admin", "User", "Manager" };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = register.Email,
                    Email = register.Email
                };
                var result = await _userManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {

                    await _userManager.AddToRolesAsync(user, register.Roles);
                    return RedirectToAction(nameof(SuccessUser));
                }
            }
            return View();
        }
        public IActionResult SuccessUser()
        {

            return View();
        }
        public IActionResult AdminUser()
        {
            return View();
        }
    }
}