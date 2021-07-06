using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class NewAdvertisementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewAdvertisementController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Store()
        {
            return View();
        }
        [Authorize(Roles ="User")]
        public IActionResult Index()
        {
            PostElanVM vm = new()
            {
                Cities = _context.Cities.ToList(),
                Stores = _context.Stores.ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(PostElanVM model)
        {
            return View();
        }
    }
}
