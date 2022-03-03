using ProjetoImobiliaria.Models;
using ProjetoImobiliaria.RepositoryOrDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace ProjetoImobiliaria.Controllers
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

        public IActionResult Imoveis()
        {
            ImoveisDB db = new ImoveisDB();
            List<Imoveis> data = db.ListAll();

            List<Tipologias> tr = db.getTipoReceitas();
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

            ImoveisDB db = new ImoveisDB();

            List<Tipologias> tr = db.getTipoReceitas();

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
        public IActionResult Create(Imoveis imovel)
        {
            
            try
            {

                ImoveisDB db = new ImoveisDB();
                db.Add(imovel);
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Imoveis");

            }
            catch (Exception e)
            {
                
                return View();                
                
            }

        }

        [HttpPost]
        
        public JsonResult Filtrar (int opcao)
        {
            ImoveisDB db = new ImoveisDB();
            List<Imoveis> lista = db.ListByEntrada(opcao);
            return Json(lista);
        }

        public IActionResult Edit (int id)
        {
            ImoveisDB db = new ImoveisDB();
            Imoveis imovel = db.ListById(id);

            List<Tipologias> tr = db.getTipoReceitas();
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
                if (tipos[n].Value == imovel.tipo_receita.ToString())
                {
                    tipos[n].Selected = true;
                }
            }

            ViewBag.Tipos = tipos;

            return View(imovel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Imoveis imovel)
        {
            ImoveisDB db = new ImoveisDB();

            try
            {
                db.Update(imovel);
                //return RedirectToAction(nameof(Imoveis));
                return RedirectToAction("Imoveis");
            }
            catch (Exception e)
            {
                return View();
            }

        }              

        //public ActionResult Delete(int id)
        //{
        //    ImoveisDB db = new ImoveisDB();
        //    Imoveis imovel = db.ListById(id);
        //    return View(imovel);
        //}

        //public ActionResult Eliminar(int id)
        //{
        //    ImoveisDB db = new ImoveisDB();
        //    Imoveis imovel = db.ListById(id);
        //    db.Delete(id);

        //    return RedirectToAction("Index");
        //}

        public ActionResult Details(int id)
        {
            ImoveisDB db = new ImoveisDB();
            Imoveis imovel = db.ListById(id);
            return View(imovel);
        }              

        public ActionResult Delete(int id)
        {
            ImoveisDB db = new ImoveisDB();
            Imoveis imovel = db.ListById(id);
            return View(imovel);
        }

        // POST: AdivinhasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ImoveisDB db = new ImoveisDB();
                db.Delete(id);
                return RedirectToAction("Imoveis");
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //public IActionResult Eliminar(int id)
        //{
        //    ImoveisDB db = new ImoveisDB();            
        //    db.Delete(id);

        //    return RedirectToAction("Index");
        //}

    }

}