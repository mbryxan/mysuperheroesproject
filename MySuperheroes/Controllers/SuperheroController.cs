﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySuperheroes.Data;
using MySuperheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySuperheroes.Controllers
{
    public class SuperheroController : Controller
    {

        private readonly ApplicationDbContext _context;

        public SuperheroController(ApplicationDbContext context)

        {
            _context = context;
        }
        // GET: SuperheroController
        // compelted
      
        public ActionResult Index()
        {
            var superheroes = _context.Superheroes;
            return View(superheroes);
        }

        // GET: SuperheroController/Details/5
        public ActionResult Details(int id, Superhero superhero)
        {
            _context.Superheroes.Find(id);
            return View(superhero);
        }

        // GET: SuperheroController/Create
        // completed
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                _context.Superheroes.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                _context.Superheroes.Update(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                _context.Superheroes.Remove(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
