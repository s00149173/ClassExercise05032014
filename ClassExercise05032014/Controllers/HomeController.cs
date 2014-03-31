using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassExercise05032014.Models;
using ClassExercise05032014.DAL;

namespace ClassExercise05032014.Controllers
{
    public class HomeController : Controller
    {
        private IMusicStoreRepository _repo;

        public HomeController(IMusicStoreRepository repo)
        {
            _repo = repo;
        }


        //
        // GET: /Home/

        public ActionResult Index()
        {
            var q = _repo.GetAllAlbums();
            return View(q);
        }

        public ActionResult test()
        {
            return View();
        }

        public ActionResult _Tracks(int id)
        {
            return PartialView("_Tracks", _repo.GetTracksByAlbumId(id));
        }

        ////
        //// GET: /Home/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    Album album = db.Albums.Find(id);
        //    if (album == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(album);
        //}

        ////
        //// GET: /Home/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Home/Create

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Albums.Add(album);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(album);
        //}

        ////
        //// GET: /Home/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    Album album = db.Albums.Find(id);
        //    if (album == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(album);
        //}

        ////
        //// POST: /Home/Edit/5

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(album).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(album);
        //}

        ////
        //// GET: /Home/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    Album album = db.Albums.Find(id);
        //    if (album == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(album);
        //}

        ////
        //// POST: /Home/Delete/5

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Album album = db.Albums.Find(id);
        //    db.Albums.Remove(album);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}