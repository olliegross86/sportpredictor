using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsResultsAPI.Models;

namespace SportsResultsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Description = "Your onestop shop for sports results";
            var api = new Utils.API();

            api.GetTeam();
            api.GetResults();

            //var conn = new Utils.Connection();
            //var rugby = conn.RugbyString();
            //rugby.ToString();
            

            var model = new SportTypeModel();
            //model.SportType = rugby.ToString();
            model.Teams = api.GetTeam().ToList();
            model.Scores = api.GetResults().ToList();
            model.Logos = api.Logos().ToList();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
