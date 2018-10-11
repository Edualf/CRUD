using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estudio.Controllers
{
    public class CarController : Controller
    {
        CarrosRepository Repo;

        public CarController() {
            Repo = new CarrosRepository();
        }
        // GET: Car
        public ActionResult Index()
        {
            var model = Repo.LeerCarros();
            return View(model);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            var model = Repo.LeerCarroPorID(id);
            return View(model);
        }

        // GET: Car/Create
        public ActionResult Create()
        {
             var model = new Carros();
            return View(model);
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Carros model)
        {
            try
            {
                Repo.AgregarCarro(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Repo.LeerCarroPorID(id);
            return View(model);
        }

        // POST: Car/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Carros model)
        {
            try
            {
               Repo.EditarCarro(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Repo.LeerCarroPorID(id);
            return View(model);
        }

        // POST: Car/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Carros model)
        {
            try
            {
                Repo.EliminarCarro(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}