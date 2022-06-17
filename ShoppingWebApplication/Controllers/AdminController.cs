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
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Product.Include(p => p.Category).Include(p => p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }
    }
}
