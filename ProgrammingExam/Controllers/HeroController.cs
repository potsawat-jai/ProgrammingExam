using Microsoft.AspNetCore.Mvc;
using ProgrammingExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingExam.Controllers
{
    public class HeroController : Controller
    {
        private ApiContext _context;

        public HeroController(ApiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Myhero);
        }
    }
}
