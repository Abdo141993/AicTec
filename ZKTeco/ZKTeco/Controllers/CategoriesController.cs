using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZKTeco.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZKTeco.Dtos.Category;
using System.Linq;
using ZKTeco.Shared;

namespace ZKTeco.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ZKTecoDbContext _context;
        private readonly Mapping _mapping;

        public CategoriesController(ZKTecoDbContext context, Mapping mapping)
        {
            _context = context;
            _mapping = mapping;
        }

        public async Task<IActionResult> Index()
        {
            var Category = await _context.Categories.Include(c => c.ParentCategory).ToListAsync();
            if (Category.Any())
                return View(Category.Select(_mapping.MapCategoryToFullDto));
            else
                return View(new List<FullCategoryDto>());
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var Category = await _context.Categories.Include(c => c.ParentCategory).FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
                return NotFound();
            ViewData["ParentCategoryId"] = new SelectList(_context.Categories, "Id", "CategoryNameEnglish");
            return View(_mapping.MapCategoryToDto(Category));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryDto dto)
        {
            ViewData["ParentCategoryId"] = new SelectList(_context.Categories, "Id", "CategoryNameEnglish");
            if (!ModelState.IsValid)
                return View();
            if (dto.ParentCategoryId == dto.Id)
            {
                ModelState.AddModelError("ParentCategoryId", "Can't be sub category");
                return View();
            }

            if (dto.ParentCategoryId != null)
            {
                var seelctedcat = _context.Categories.FirstOrDefault(x => x.Id == dto.ParentCategoryId);
                if (dto.Id == seelctedcat.ParentCategoryId)
                {
                    ModelState.AddModelError("ParentCategoryId", "Can't be sub categoey");
                    return View();
                }
            }
            var Oldcategory = _context.Categories.FirstOrDefault(x => x.Id == dto.Id);
            Oldcategory.CategoryNameEnglish = dto.CategoryNameEnglish;
            Oldcategory.CategoryNameArabic = dto.CategoryNameArabic;
            Oldcategory.Description = dto.Description;
            Oldcategory.ParentCategoryId = dto.ParentCategoryId;

            _context.Attach(Oldcategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
            return RedirectToAction("Index", "Categories");
        }

        public IActionResult Add()
        {
            ViewData["ParentCategoryId"] = new SelectList(_context.Categories, "Id", "CategoryNameEnglish");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto dto)
        {
            ViewData["ParentCategoryId"] = new SelectList(_context.Categories, "Id", "CategoryNameEnglish");
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (dto.ParentCategoryId == dto.Id)
            {
                ModelState.AddModelError("ParentCategoryId", "Can't be sub category");
                return View();
            }
            dto.CreatedDate = DateTime.Now;
            _context.Categories.Add(_mapping.MapCategoryToModel(dto));
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Categories");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category category = await _context.Categories
                .Include(c => c.ParentCategory).FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(_mapping.MapCategoryToFullDto(category));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category category = await _context.Categories
                .Include(c => c.ParentCategory).FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(_mapping.MapCategoryToFullDto(category));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category category = await _context.Categories.FindAsync(id);
            var products = _context.Products.Where(x => x.CategoryId == id).ToList();
            products.ForEach(x => x.CategoryId = null);
            if (category != null)
            {
                var allcategories = _context.Categories.ToList();
                foreach (var item in allcategories)
                {
                    if (category.ParentCategoryId == item.ParentCategoryId)
                    {
                        item.ParentCategoryId = null;
                        _context.SaveChanges();
                    }
                }
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Categories");
        }

    }
}
