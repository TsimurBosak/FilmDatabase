using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Timur.Models;
using System.Data.Entity;

namespace Timur.Controllers
{
    public class HomeController : Controller
    {
        TimurContext db = new TimurContext();
            
            public ActionResult Index(string sortOrder, string searchString, int? x, int? z)
            {

                ViewBag.SearchStatus = 0;
                ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name desc" : "";
                ViewBag.YearSortParm = sortOrder == "Year" ? "Year desc" : "Year";
                ViewBag.LengthSortParm = sortOrder == "Length" ? "Length desc" : "Length";
                var films = from s in db.Films select s;
                var SelectedFilms = films;

            switch (x)
            {
                case 1:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 2:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 3:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 4:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 5:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 6:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 7:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 8:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 9:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 10:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 11:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 12:
                    SelectedFilms = from film in db.Films
                                    where film.Genres.Any(c => c.Id == x)
                                    select film;
                    ViewBag.GenreId = x;

                    break;
                case 13:  ViewBag.GenreId = x; return View(SelectedFilms.ToList());
                default:
                    break;
            }
            switch (z)
                {
                    case 1:
                        SelectedFilms = SelectedFilms.Where(p => p.Film_year >= 1990 && p.Film_year <= 1995);
                        ViewBag.YearId = z;
                        ViewBag.Test = 1;
                        break;
                    case 2:
                        SelectedFilms = SelectedFilms.Where(p => p.Film_year >= 1995 && p.Film_year <= 2000);
                        ViewBag.YearId = z;
                        break;
                    case 3:
                        SelectedFilms = SelectedFilms.Where(p => p.Film_year >= 2000 && p.Film_year <= 2005);
                        ViewBag.YearId = z;
                        break;
                    case 4:
                        SelectedFilms = SelectedFilms.Where(p => p.Film_year >= 2005 && p.Film_year <= 2010);
                        ViewBag.YearId = z;
                        break;
                    case 5:
                        SelectedFilms = SelectedFilms.Where(p => p.Film_year >= 2010 && p.Film_year <= 2015);
                        ViewBag.YearId = z;
                        break;
                    case 6:
                        SelectedFilms = SelectedFilms.Where(p => p.Film_year >= 2015 && p.Film_year <= 2020);
                        ViewBag.YearId = z;
                        break;
                    case 7: ViewBag.YearId = z; return View(SelectedFilms.ToList()); 
                default:
                    break;
                }
            if (!String.IsNullOrEmpty(searchString))
                {
                SelectedFilms = SelectedFilms.Where(s => s.Film_name.ToUpper().Contains(searchString.ToUpper()));
                ViewBag.SearchId = searchString;
                if (SelectedFilms==null)
                ViewBag.SearchStatus = 1;
                }      
                switch (sortOrder)
                {
                    case "Name desc":
                        SelectedFilms = SelectedFilms.OrderByDescending(p => p.Film_name);
                        break;
                    case "Year":
                        SelectedFilms = SelectedFilms.OrderBy(p => p.Film_year);
                        break;
                    case "Year desc":
                        SelectedFilms = SelectedFilms.OrderByDescending(p => p.Film_year);
                        break;
                    case "Length":
                        SelectedFilms = SelectedFilms.OrderBy(p => p.Film_leng);
                        break;
                    case "Length desc":
                        SelectedFilms = SelectedFilms.OrderByDescending(p => p.Film_leng);
                        break;
                    default:
                        SelectedFilms = SelectedFilms.OrderBy(p => p.Film_name);
                        break;
                }
                return View(SelectedFilms.ToList());
            }
        [Authorize]
        public ActionResult Details(int id)
        {
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }
        public ActionResult GetUser()
        {
            var name = User.Identity.Name;

            User selectedUser = db.Users.FirstOrDefault(u => u.Login == name);
            return View(selectedUser);
        }
        public ActionResult Buy(int x)
        {
            using (var context = new TimurContext())
            {
                var name = User.Identity.Name;
                User u1 = db.Users.FirstOrDefault(u => u.Login == name);
                int z = u1.Id;
                User u2 = new User { Id = z };
                context.Users.Add(u2);
                context.Users.Attach(u2);
                Film f1 = new Film { Id = x };
                context.Films.Add(f1);
                context.Films.Attach(f1);
                u2.Films.Add(f1);
                context.SaveChanges();
                return RedirectToAction("GetUser", "Home");
            }
        }
        [HttpGet]
        public ActionResult UpBalance()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpBalance(string card, int sum)
        {
            using (var context = new TimurContext())
            {
                var name = User.Identity.Name;
                User u1 = db.Users.FirstOrDefault(u => u.Login == name);
                int z = u1.Id;
                User u2 = new User { Id = z };
                Bill bill = new Bill();
                bill.Card_number = card;
                bill.Balance = sum;
                u2.Bills.Add(bill);
                context.SaveChanges();
                
            }

                return RedirectToAction("GetUser", "Home");
        }
    }
}