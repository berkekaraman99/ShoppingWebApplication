﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoppingWebApplication.Data;
using ShoppingWebApplication.Models;

namespace ShoppingWebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
              return _context.Category != null ? 
                          View(await _context.Category.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Category'  is null.");
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Category == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Category'  is null.");
            }
            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                _context.Category.Remove(category);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
          return (_context.Category?.Any(e => e.CategoryId == id)).GetValueOrDefault();
        }

        public IActionResult TShirt()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Coat()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Jacket()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Jeans()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Shirt()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Short()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Suit()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Sweater()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Sweatshirt()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Tracksuit()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Trousers()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }

        public IActionResult Waistcoat()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }
    }
}
