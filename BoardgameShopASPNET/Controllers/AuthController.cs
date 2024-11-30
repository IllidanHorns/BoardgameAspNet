using BoardgameShop.WEBUI.Models.DbEntities;
using BoardgameShop.WEBUI.Models.SideModels;
using BoardgameShopASPNET.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics;
using System.Security.Claims;

namespace BoardgameShop.WEBUI.Controllers
{
    public class AuthController : Controller
    {
        AppDbContext _context;
        public IActionResult Index()
        {
            return View();
        }

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SignIn()
        {
            if (HttpContext.Session.Keys.Contains("AuthUser"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View("SignIn");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                AccountUser user = await _context.AccountUsers.FirstOrDefaultAsync(x => x.Login == model.Login && x.Password == model.Password);
                if (user != null)
                {
                    HttpContext.Session.SetString("AuthUser", model.Login);
                    await Authenticate(model.Login);

                    return RedirectToAction("Index", "Home");
                    Console.Write("qweqweqwe");
                }
                ModelState.AddModelError("", "Некорректнные логин или пароль!");

            }

            return RedirectToAction("SignIn", "Auth");
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            { new Claim(ClaimsIdentity.DefaultNameClaimType, userName) };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.Session.Remove("AuthUser");
            return RedirectToAction("SignIn");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = new AccountUser
                {
                    Login = model.Login,
                    Password = model.Password,
                    RoleAccount_ID = 1
                };
                _context.AccountUsers.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("SignIn");
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}
