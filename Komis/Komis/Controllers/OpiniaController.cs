using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository _opiniaRepository;

        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            _opiniaRepository = opiniaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            _opiniaRepository.DodajOpinie(opinia);

            return RedirectToAction("OpiniaWyslana");
        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}