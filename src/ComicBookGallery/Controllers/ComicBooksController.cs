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

        // GET: ComicBooks/Detail/{i}
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ComicBook comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);
        }
    }
}