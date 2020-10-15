using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Superheros.Controllers
{
    public class SuperherosController : Controller
    {
        // GET: SuperherosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperherosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperherosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperherosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: SuperherosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperherosController/Edit/5
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

        // GET: SuperherosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperherosController/Delete/5
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
