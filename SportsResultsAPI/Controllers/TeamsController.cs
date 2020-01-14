using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsResultsAPI.Models;

namespace SportsResultsAPI.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        public ActionResult Index()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();

            return View(model);
        }

        public ActionResult Team0()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();


            return View(model);
        }
        public ActionResult Team1()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team2()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team3()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team4()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team5()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team6()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team7()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team8()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team9()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team10()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }
        public ActionResult Team11()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }     public ActionResult Team12()
        {
            var api = new Utils.API();
            var model = new TeamsModel();
            model.Logos = api.Logos().ToList();
            model.Teams = api.GetTeam().ToList();
            model.Results = api.GetResults().ToList();
            model.Fixtures = api.GetFixtures().ToList();

            return View(model);
        }


        // GET: Teams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
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

        // GET: Teams/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teams/Edit/5
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

        // GET: Teams/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teams/Delete/5
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