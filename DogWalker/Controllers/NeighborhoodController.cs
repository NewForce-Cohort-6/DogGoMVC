using DogWalker.Models;
using DogWalker.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DogWalker.Controllers
{
    public class NeighborhoodController : Controller
    {
        private readonly INeighborhoodRepository _neighborhoodRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public NeighborhoodController(INeighborhoodRepository neighborhoodRepository)
        {
            _neighborhoodRepo = neighborhoodRepository;
        }
        // GET: NeighborhoodController
        public ActionResult Index()
        {
            List<Neighborhood> neighborhoods = _neighborhoodRepo.GetAllNeighborhoods();
            return View(neighborhoods);
        }

        // GET: NeighborhoodController/Details/5
        public ActionResult Details(int id)
        {
            Neighborhood neighborhood = _neighborhoodRepo.GetNeighborhoodById(id);

            if (neighborhood == null)
            {
                return NotFound();
            }
            return View(neighborhood);
        }

        // GET: NeighborhoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NeighborhoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Neighborhood neighborhood)
        {
            try
            {
                _neighborhoodRepo.AddNeighborhood(neighborhood);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(neighborhood);
            }
        }

        // GET: NeighborhoodController/Edit/5
        public ActionResult Edit(int id)
        {
            Neighborhood neighborhood = _neighborhoodRepo.GetNeighborhoodById(id);
            if (neighborhood == null)
            {
                return NotFound();
            }
            return View(neighborhood);
        }

        // POST: NeighborhoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Neighborhood neighborhood)
        {
            try
            {
                _neighborhoodRepo.UpdateNeighborhood(neighborhood);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(neighborhood);
            }
        }

        // GET: NeighborhoodController/Delete/5
        public ActionResult Delete(int id)
        {
            Neighborhood neighborhood = _neighborhoodRepo.GetNeighborhoodById(id);
            return View(neighborhood);
        }

        // POST: NeighborhoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Neighborhood neighborhood)
        {
            try
            {
                _neighborhoodRepo.DeleteNeighborhood(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(neighborhood);
            }
        }
    }
}