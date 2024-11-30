using BoardgameShopASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardgameShop.WEBUI.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext _context;
        public IActionResult Index()
        {
            return View(_context.Products);
        }

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

    }
}
