using _01_Adivinhas.Models;
using _01_Adivinhas.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _01_Adivinhas.Controllers
{
    public class AdivinhasController : Controller
    {

        private AdivinhasRepository ar = new AdivinhasRepository();
        
        // GET: AdivinhasController
        public ActionResult Index()
        {
            List<Adivinhas> adv = ar.ListAll();

            return View(adv);
        }

        // GET: AdivinhasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdivinhasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdivinhasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Adivinhas adivinha)
        {
            try
            {
                ar.Add(adivinha);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdivinhasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdivinhasController/Edit/5
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

        // GET: AdivinhasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdivinhasController/Delete/5
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
