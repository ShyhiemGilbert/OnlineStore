using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stores.Models;

namespace Stores.Controllers
{
    public class StoreController : Controller
    {
        //Store controller will support
        //A listing page of the music genres in our music store
        //A browse page that lists all of the music albums in a particular genre
        //A details page that shows information about a specific music album

        //"Index" method to implement our listing page that lists all genres in our store
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco" },
                new Genre { Name = "Jazz" },
                new Genre { Name = "Rock" }

            };
            return View(genres);
        }

        // GET: /Store/Browse?genre=Fiction
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}