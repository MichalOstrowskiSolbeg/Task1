using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task1_Calculator.Interfaces;
using Task1_Calculator.Models;
using Task1_Calculator.Services;

namespace Task1_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMath _math;

        public HomeController(ILogger<HomeController> logger, IMath math)
        {
            _logger = logger;
            _math = math;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(MathModel model, string a)
        {
            model.exceptionMessage = "";

            switch (a)
            {
                case "Add":
                    model.result = _math.Add(model.value1, model.value2);
                    break;
                case "Subtract":
                    model.result = _math.Subtract(model.value1, model.value2);
                    break;
                case "Multiply":
                    model.result = _math.Multiply(model.value1, model.value2);
                    break;
                default:
                    try
                    {
                        model.result = _math.Divide(model.value1, model.value2);
                    } catch (Exception e)
                    {
                        model.exceptionMessage = e.Message;
                    }

                    break;
            }

            return View("Index", model);
        }
    }
}