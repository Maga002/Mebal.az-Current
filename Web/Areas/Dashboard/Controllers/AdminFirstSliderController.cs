using DataAccess;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AdminFirstSliderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AdminFirstSliderController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.FirstSliders.ToList());
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
           FirstSlider slider= _context.FirstSliders.FirstOrDefault(x => x.ID == id);
            return View(slider);
        }
        [HttpPost]
        public IActionResult Edit(int? id, FirstSlider firstslider, IFormFile Photo)
        {
            if (id == null) return NotFound();
            if (Photo != null)
            {
                string ImgName = Guid.NewGuid() + "_" + Photo.FileName;
                string uploadLink = Path.Combine(_env.WebRootPath, "uploads");
                string filePath = Path.Combine(uploadLink, ImgName);
                using FileStream file = new FileStream(filePath, FileMode.Create);
                Photo.CopyTo(file);
                firstslider.PhotoURL = ImgName;
            }
           
            _context.FirstSliders.Update(firstslider);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
