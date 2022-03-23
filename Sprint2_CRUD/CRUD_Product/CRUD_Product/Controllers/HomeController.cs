using CRUD_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUD_Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Product> Products = new List<Product>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {       
  
            return View(Products);
        }
        [HttpPost]
        public void ADD_Product(Product product)
        {
            Console.WriteLine("add");
            Products.Add(product);
       
        }
    }
}