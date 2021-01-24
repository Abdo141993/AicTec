using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dto.AboutUs;
using ZKTeco.Models;
using ZKTeco.Shared;

namespace ZKTeco.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ZKTecoDbContext _context;
        private readonly Mapping _mapping;
        public AboutUsController(IHostingEnvironment hostingEnvironment, ZKTecoDbContext context, Mapping mapping)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
            _mapping = mapping;
        }
        public IActionResult Index()
        {
            var v = _context.AboutUs.FirstOrDefault();
            if (v != null)
                return RedirectToAction("Edit", "AboutUs", new { id = v.Id });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexPost(AboutUsWithFileForm dto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.AboutUs.ToList().Count >= 1)
            {
                ModelState.AddModelError("title", "can't add new about us ");
                return View();
            }
            if (dto.photourlFormFile != null)
            {
                var uploadFilepath = Path.Combine(_hostingEnvironment.WebRootPath, "images/aboutus");
                string uniqname = Guid.NewGuid().ToString() + "_" + dto.photourlFormFile.FileName;
                string filePath = Path.Combine(uploadFilepath, uniqname);
                dto.photourlFormFile.CopyTo(new FileStream(filePath, FileMode.Create));
                dto.photourl = "/images/aboutus/" + uniqname;
            }

            _context.AboutUs.Add(_mapping.MapAboutUsToModel(dto));
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "AboutUs");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            AboutU aboutUs = await _context.AboutUs.FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUs == null)
                return NotFound();
            return View(_mapping.MapAboutUsToDto(aboutUs));
        }
        [HttpPost]
        public async Task<IActionResult> EditPost(AboutUsWithFileForm dto)
        {
            string uniqname = null;
            string filePath = null;
            var oldaboutus = _context.AboutUs.AsNoTracking().FirstOrDefault(x => x.Id == dto.Id);
            if (!ModelState.IsValid)
            {
                dto.photourl = oldaboutus.Photourl;
                return View();
            }
            if (dto.photourlFormFile != null)
            {
                var uploadFilepath = Path.Combine(_hostingEnvironment.WebRootPath, "images/aboutus");
                uniqname = Guid.NewGuid().ToString() + "_" + dto.photourlFormFile.FileName;
                filePath = Path.Combine(uploadFilepath, uniqname);
                dto.photourlFormFile.CopyTo(new FileStream(filePath, FileMode.Create));
                // Delete Old Image
                var fullPath = _hostingEnvironment.WebRootPath + oldaboutus.Photourl;
                if (System.IO.File.Exists(fullPath))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    System.IO.File.Delete(fullPath);
                }
                    
                // Add New Image
                dto.photourl = "/images/aboutus/" + uniqname;
            }
            else
            {
                //var oldaboutus = _context.AboutUs.AsNoTracking().FirstOrDefault(x => x.Id == dto.Id);
                dto.photourl = oldaboutus.Photourl;
            }
            //////////
            _context.Attach(_mapping.MapAboutUsToModel(dto)).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!aboutUsExists(dto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction("Index", "AboutUs");
        }

        private bool aboutUsExists(int id)
        {
            return _context.AboutUs.Any(e => e.Id == id);
        }


    }
}
