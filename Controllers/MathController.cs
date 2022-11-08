using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1_Calculator.Services;

namespace Task1_Calculator.Controllers
{
    public class MathController : Controller
    {
        private readonly MathService _mathService;

        public MathController(MathService mathService)
        {
            _mathService = mathService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
