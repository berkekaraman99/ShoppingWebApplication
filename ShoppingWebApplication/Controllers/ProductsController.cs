using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoppingWebApplication.Data;
using ShoppingWebApplication.Models;

namespace ShoppingWebApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(int id)
        {
            //var applicationDbContext = _context.Product.Include(p => p.Category).Include(p => p.Colour);
            ViewBag.Action = "Index";
            ViewBag.Categories = _context.Category.OrderBy(g => g.CategoryName).ToList();
            ViewBag.Colours = _context.Colour.OrderBy(g => g.ColourName).ToList();
            var product = _context.Product.Find(id);
            ViewBag.ProductName = product.ProductName;
            ViewBag.Description = product.Description;
            ViewBag.Price = product.Price;
            ViewBag.Image = product.ImagePath;
            ViewBag.Supplier = product.Supplier;
            return View(product);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Colour)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return _context.Product != null ?
                        View("ShowSearchForm") :
                        Problem("Entity set 'ApplicationDbContext.Product'  is null.");
        }

        // GET: Products/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index", await _context.Product.Where(p => p.ProductName.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Products/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Category.OrderBy(g => g.CategoryName).ToList();
            ViewBag.Colours = _context.Colour.OrderBy(g => g.ColourName).ToList();
            return View();
        }

        // POST: Products/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Price,Description,ColourId,CategoryId,Supplier,ImagePath")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = _context.Category.OrderBy(g => g.CategoryName).ToList();
            ViewBag.Colours = _context.Colour.OrderBy(g => g.ColourName).ToList();
            return View(product);
        }

        // GET: Products/Edit/
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.Categories = _context.Category.OrderBy(g => g.CategoryName).ToList();
            ViewBag.Colours = _context.Colour.OrderBy(g => g.ColourName).ToList();
            return View(product);
        }

        // POST: Products/Edit/
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Price,Description,ColourId,CategoryId,Supplier,ImagePath")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewBag.Categories = _context.Category.OrderBy(g => g.CategoryName).ToList();
            ViewBag.Colours = _context.Colour.OrderBy(g => g.ColourName).ToList();
            return View(product);
        }

        // GET: Products/Delete/
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Colour)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Product == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Product'  is null.");
            }
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return View("Success");
        }

        private bool ProductExists(int id)
        {
          return (_context.Product?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
