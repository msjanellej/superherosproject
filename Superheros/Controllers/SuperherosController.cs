using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheros.Data;
using Superheros.Models;

namespace Superheros.Controllers
{
    public class SuperherosController : Controller
    {
        private readonly ApplicationDbContext db;

        public SuperherosController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: SuperherosController
        public ActionResult Index()
        {
            var superherosFromDatabase = db.Superheros.ToList();
            return View(superherosFromDatabase);
        }

        // GET: SuperherosController/Details/5
        public ActionResult Details(int id)
        {
            var superherotoView = db.Superheros.Where(s => s.Id == id).SingleOrDefault();
            return View(superherotoView);
        }

        // GET: SuperherosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperherosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                db.Superheros.Add(superhero);
                db.SaveChanges();

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
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                //identify the area the superhero has been updated on the form
                // update the property that has been selected
                var superheroToUpdate = db.Superheros.Where(s => s.Id == id).SingleOrDefault();

                if (superhero.SuperheroName != null)
                {
                    superheroToUpdate.SuperheroName = superhero.SuperheroName;
                }
                if (superhero.PrimarySuperAbility != null)
                {
                    superheroToUpdate.PrimarySuperAbility = superhero.PrimarySuperAbility;
                }
                if (superhero.SecondarySuperAbility != null)
                {
                    superheroToUpdate.SecondarySuperAbility = superhero.SecondarySuperAbility;
                }
                if (superhero.Catchphrase != null)
                {
                    superheroToUpdate.Catchphrase = superhero.Catchphrase;
                }
                db.SaveChanges();

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
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                var superheroToDelete = db.Superheros.Where(s => s.Id == id).SingleOrDefault();
                db.Superheros.Remove(superheroToDelete);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
