using _01_Adivinhas.Models;
using _01_Adivinhas.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _01_Adivinhas.Controllers
{
    public class AnedotasController : Controller
    {

        private AnedotasRepository anr = new AnedotasRepository();
        private Anedotas anedota;

        // GET: AnedotasController
        public ActionResult Index()
        {
            List<Anedotas> adv = anr.ListAll();
            return View(adv);
        }

        // GET: AnedotasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnedotasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnedotasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                anr.Add(anedota);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnedotasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnedotasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnedotasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnedotasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
