using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Genre_name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public Genre()
        {
            Films = new List<Film>();
        }
    }
}