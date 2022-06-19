using System;
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
