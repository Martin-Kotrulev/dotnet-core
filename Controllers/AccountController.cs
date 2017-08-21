using System.Threading.Tasks;
using App.Controllers.Resources;
using App.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _loginManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> loginManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _loginManager = loginManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterResource resource)
        {
            if (ModelState.IsValid) {
                var user = new ApplicationUser() { UserName = resource.Username };
                var result = await _userManager.CreateAsync(user, resource.Password);

                if (result.Succeeded) {
                    System.Console.WriteLine("Registered!");
                    return Ok();
                }

                return BadRequest(ModelState);
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(RegisterResource resource)
        {
            System.Console.WriteLine(_userManager == null);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Logout(RegisterResource resource)
        {
            System.Console.WriteLine(_userManager == null);
            return Ok();
        }
    }
}