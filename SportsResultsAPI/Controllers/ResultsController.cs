using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SportsResultsAPI.Models;

namespace SportsResultsAPI.Controllers
{
    public class ResultsController : Controller
    {
        // GET: Results
        public ActionResult Index()
        {
            ViewBag.Description = "Your onestop shop for sports results";
            var api = new Utils.API();

            api.GetTeam();
            api.GetResults();

            var conn = new Utils.Connection();

            var model = new ResultsModel();
            model.Results = api.GetResults().ToList();
            model.Videos = api.GetVideos().ToList();           
            return View(model);
        }

        public ActionResult Predictions()
        {
            ViewBag.Description = "Predictions";
            var api = new Utils.API();

            api.GetTeam();
            api.GetFixtures();
            api.GetResults();

            var conn = new Utils.Connection();

            var model = new FixturesModel();
            model.Fixtures = api.GetFixtures().ToList();
            model.Results = api.GetResults().ToList();
            model.Teams = api.GetTeam().ToList();

            return View(model);
        }

        // GET: Results/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Results/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Results/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Results/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Results/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Results/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Results/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}