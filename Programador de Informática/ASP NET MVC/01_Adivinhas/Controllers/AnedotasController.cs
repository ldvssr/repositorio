
using _01_Adivinhas.Models;
using _01_Adivinhas.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Adivinhas.Controllers
{
    public class AnedotasController : Controller
    {
        private AnedotasRepository anRepo = new AnedotasRepository();

        // GET: AnedotasController
        public ActionResult Index()
        {
            List<Anedotas> an = anRepo.ListAll();
            return View(an);
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
        public ActionResult Create(Anedotas _aned)
        {
            try
            {
                anRepo.Add(_aned);
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
