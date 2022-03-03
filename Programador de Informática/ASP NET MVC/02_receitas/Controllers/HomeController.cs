using _02_receitas.Models;
using _02_receitas.RepositoryOrDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace _02_receitas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Receitas()
        {
            ReceitasDB db = new ReceitasDB();
            List<Receitas> data = db.ListAll();

            List<Tipos_receitas> tr = db.getTipoReceitas();
            List<SelectListItem> tipos = new List<SelectListItem>();

            foreach(var item in tr)
            {
                tipos.Add(new SelectListItem(
                    
                    item.tipo,
                    item.id.ToString()
                    
                    ));
            }

            ViewBag.Tipos = tipos;

            return View(data);
        }

        public IActionResult Create()
        {

            ReceitasDB db = new ReceitasDB();

            List<Tipos_receitas> tr = db.getTipoReceitas();

            List<SelectListItem> tipos = new List<SelectListItem>();

            foreach (var item in tr)
            {
                tipos.Add(new SelectListItem(
                    item.tipo,
                    item.id.ToString()
                    ));
            }

            ViewBag.Tipos = tipos;
            
            return View();

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Receitas receita)
        {
            
            try
            {

                ReceitasDB db = new ReceitasDB();
                db.Add(receita);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                
                return View();                
                
            }

        }

        [HttpPost]
        
        public JsonResult Filtrar (int opcao)
        {
            ReceitasDB db = new ReceitasDB();
            List<Receitas> lista = db.ListByEntrada(opcao);
            return Json(lista);
        }

        public IActionResult Edit (int id)
        {
            ReceitasDB db = new ReceitasDB();
            Receitas receita = db.ListById(id);

            List<Tipos_receitas> tr = db.getTipoReceitas();
            List<SelectListItem> tipos = new List<SelectListItem>();

            foreach (var item in tr)
            {
                tipos.Add(new SelectListItem(
                        item.tipo,
                        item.id.ToString()
                    ));
            }

            for (int n = 0; n < tipos.Count; n++)
            {
                if (tipos[n].Value == receita.tipo_receita.ToString())
                {
                    tipos[n].Selected = true;
                }
            }

            ViewBag.Tipos = tipos;

            return View(receita);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Receitas receita)
        {
            ReceitasDB db = new ReceitasDB();

            try
            {
                db.Update(receita);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }

        }

    }

}