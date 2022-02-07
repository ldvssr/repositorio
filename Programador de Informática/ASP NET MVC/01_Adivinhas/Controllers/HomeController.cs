using _01_Adivinhas.Models;
using _01_Adivinhas.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Adivinhas.Controllers
{
    public class HomeController : Controller
    {
        private AdivinhasRepository ar = new AdivinhasRepository();

        private AnedotasRepository anr = new AnedotasRepository();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Adivinhas> adv = ar.ListAll();
            return View(adv);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Resposta(string adivinha)
        {
            if (adivinha == "0") return RedirectToAction("Index", "Home");
            Adivinhas resposta = ar.ListById(Convert.ToInt32(adivinha));
            return View(resposta);
        }

    }
}
