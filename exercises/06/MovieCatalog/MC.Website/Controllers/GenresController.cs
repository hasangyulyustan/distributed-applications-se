using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC.Website.ViewModels;

namespace MC.Website.Controllers
{
    public class GenresController : Controller
    {
        // GET: Genres
        // GET: Movies
        public ActionResult Index()
        {
            List<GenreVM> genresVM = new List<GenreVM>();
            using (GenresReference.GenresClient service = new GenresReference.GenresClient())
            {
                foreach (var item in service.GetGenres())
                {
                    genresVM.Add(new GenreVM(item));
                }
            }
            return View(genresVM);
        }

        // GET: Genres/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Genres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        [HttpPost]
        public ActionResult Create(GenreVM genreVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (GenresReference.GenresClient service = new GenresReference.GenresClient())
                    {
                        GenresReference.GenreDto genreDto = new GenresReference.GenreDto
                        {
                            Name = genreVM.Name,
                            Id = genreVM.Id
                        };
                        service.PostGenre(genreDto);
                    }

                    return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Genres/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Genres/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
