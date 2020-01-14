using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Timur.Models;

namespace Timur.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        TimurContext db = new TimurContext();
        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult GenreList()
        {
            var genres = db.Genres;
            return View(genres.ToList());
        }
        [HttpGet]
        public ActionResult CreateGenre()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateGenre(Genre genre)
        {
            db.Genres.Add(genre);
            db.SaveChanges();
            return RedirectToAction("GenreList","Admin");
        }
        [HttpGet]
        public ActionResult EditGenre(int id)
        {
            Genre genre = db.Genres.Find(id);
            if (genre != null)
            {
                return View(genre);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditGenre(Genre genre)
        {
            db.Entry(genre).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("GenreList","Admin");
        }
        public ActionResult DeleteGenre(int id)
        {
            Genre genre = db.Genres.Find(id);
            if (genre != null)
            {
                db.Genres.Remove(genre);
                db.SaveChanges();
            }
            return RedirectToAction("GenreList","Admin");
        }
        public ActionResult ProducerList()
        {
            var producers = db.Producers;
            return View(producers.ToList());
        }
        [HttpGet]
        public ActionResult CreateProducer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProducer(Producer producer)
        {
            db.Producers.Add(producer);
            db.SaveChanges();
            return RedirectToAction("ProducerList", "Admin");
        }
        [HttpGet]
        public ActionResult EditProducer(int id)
        {
            Producer producer = db.Producers.Find(id);
            if (producer != null)
            {
                return View(producer);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditProducer(Producer producer)
        {
            db.Entry(producer).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ProducerList", "Admin");
        }
        public ActionResult DeleteProducer(int id)
        {
            Producer producer = db.Producers.Find(id);
            if (producer != null)
            {
                db.Producers.Remove(producer);
                db.SaveChanges();
            }
            return RedirectToAction("ProducerList", "Admin");
        }
        public ActionResult CountryList()
        {
            var countries = db.Countries;
            return View(countries.ToList());
        }
        [HttpGet]
        public ActionResult CreateCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCountry(Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();
            return RedirectToAction("CountryList", "Admin");
        }
        [HttpGet]
        public ActionResult EditCountry(int id)
        {
            Country country = db.Countries.Find(id);
            if (country != null)
            {
                return View(country);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditCountry(Country country)
        {
            db.Entry(country).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("CountryList", "Admin");
        }
        public ActionResult DeleteCountry(int id)
        {
            Country country = db.Countries.Find(id);
            if (country != null)
            {
                db.Countries.Remove(country);
                db.SaveChanges();
            }
            return RedirectToAction("CountryList", "Admin");
        }
        public ActionResult ActorList()
        {
            var actors = db.Actors;
            return View(actors.ToList());
        }
        [HttpGet]
        public ActionResult CreateActor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateActor(Actor actor)
        {
            db.Actors.Add(actor);
            db.SaveChanges();
            return RedirectToAction("ActorList", "Admin");
        }
        [HttpGet]
        public ActionResult EditActor(int id)
        {
            Actor actor = db.Actors.Find(id);
            if (actor != null)
            {
                return View(actor);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditActor(Actor actor)
        {
            db.Entry(actor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ActorList", "Admin");
        }
        public ActionResult DeleteActor(int id)
        {
            Actor actor = db.Actors.Find(id);
            if (actor != null)
            {
                db.Actors.Remove(actor);
                db.SaveChanges();
            }
            return RedirectToAction("ActorList", "Admin");
        }
        public ActionResult FilmList()
        {
            var films = db.Films;
            return View(films.ToList());
        }
        [HttpGet]
        public ActionResult CreateFilm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFilm(Film film)
        {
            db.Films.Add(film);
            db.SaveChanges();
            return RedirectToAction("FilmList", "Admin");
        }
        [HttpGet]
        public ActionResult EditFilm(int id)
        {
            Film film = db.Films.Find(id);
            if (film != null)
            {
                return View(film);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditFilm(Film film)
        {
            db.Entry(film).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("FilmList", "Admin");
        }
        public ActionResult DeleteFilm(int id)
        {
            Film film = db.Films.Find(id);
            if (film != null)
            {
                db.Films.Remove(film);
                db.SaveChanges();
            }
            return RedirectToAction("FilmList", "Admin");
        }
        public ActionResult UserList()
        {
            var users = db.Users;
            return View(users.ToList());
        }
        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("UserList", "Admin");
        }
        [HttpGet]
        public ActionResult EditUser(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                return View(user);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditUser(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("UserList", "Admin");
        }
        public ActionResult DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("FilmList", "Admin");
        }
    }
}