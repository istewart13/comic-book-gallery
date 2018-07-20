using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }

        // GET: ComicBooks/Detail
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist()
                    {
                        Name = "Script",
                        Role = "Dan Slott"
                    },
                    new Artist()
                    {
                        Name = "Pencils",
                        Role = "Humberto Ramos"
                    },
                    new Artist()
                    {
                        Name = "Inks",
                        Role = "Victor Olazaba"
                    },
                    new Artist()
                    {
                        Name = "Colors",
                        Role = "Edgar Delgado"
                    },
                    new Artist()
                    {
                        Name = "Letters",
                        Role = "Chris Eliopoulos"
                    }
                }
            };
            return View(comicBook);
        }
    }
}