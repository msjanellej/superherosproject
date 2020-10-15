﻿using System;
using System.Collections.Generic;
using System.Linq;
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
                db.Superheros.Remove(superhero);
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
