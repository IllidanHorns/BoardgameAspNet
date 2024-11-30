using BoardgameShop.WEBUI.Models.DbEntities;
using BoardgameShop.WEBUI.Models.SideModels;
using BoardgameShopASPNET.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace BoardgameShopASPNET.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>Index()
        {
            int countOfImgsIgroteka = 6;
            ViewBag.CountOfImgsIgroteka = countOfImgsIgroteka;
            ViewBag.CountOfHiBlockIgroteka = 5;
            return View(await _context.Users.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
