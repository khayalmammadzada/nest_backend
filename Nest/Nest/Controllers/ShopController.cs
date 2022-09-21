using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest.DAL;
using Nest.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nest.Controllers
{
    public class ShopController : Controller
    {
        private NestContext _context { get; set; }

        public ShopController(NestContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            //ShopVM shop = new ShopVM
            //{
            //    ProductTags = _context.Products.Include(p => p.Tags).Where(c => !c.IsDeleted)
            //};
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Compare()
        {
            return View();
        }

    }
}

