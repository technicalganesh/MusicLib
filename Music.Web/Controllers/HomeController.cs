using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Music.Entities;
using Music.Standards;
using Music.Store;
using Music.Web.Models;

namespace Music.Web.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        private IDataRepository<Album> _albumStore;

        public HomeController (ILogger<HomeController> logger, IDataRepository<Album> albumStore) {
            _logger = logger;
            _albumStore = albumStore;
        }

        public IActionResult Index () {

            return View (_albumStore.GetAll ());
        }

        public IActionResult Privacy () {

            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}