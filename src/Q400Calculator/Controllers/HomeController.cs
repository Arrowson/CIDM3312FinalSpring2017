using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;

namespace Q400Calculator.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Inputs inputs = new Inputs();
            
            return View(inputs);
        }
       

    
        public IActionResult Outputs(Inputs inputs) {
            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
