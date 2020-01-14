using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class Film
    {
        public virtual ICollection<Producer> Producers { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public int Id { get; set; }
        public string Film_name { get; set; }
        public int Film_year { get; set; }
        public int Film_leng { get; set; }
        public int Film_price { get; set; }
        public string Film_description { get; set; }
        public string Film_picture { get; set; }
        public Film()
        {
            Countries = new List<Country>();
            Genres = new List<Genre>();
            Actors = new List<Actor>();
            Producers = new List<Producer>();
            Users = new List<User>();
        }
    }
}