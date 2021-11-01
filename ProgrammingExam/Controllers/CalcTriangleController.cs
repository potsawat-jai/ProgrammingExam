using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProgrammingExam.Controllers
{
    public class CalcTriangleController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("api/Calc")]
        [HttpPost]
        public double Calctriangle(HttpRequestMessage request, [FromBody] bodycalc obj)
        {
            var TriangleArea = (obj.Base * obj.Height) / 2;

            return TriangleArea;
        }

        public class bodycalc
        {
            public double Base { get; set; }
            public double Height { get; set; }
        }
    }
}
