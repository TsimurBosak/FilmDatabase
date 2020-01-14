using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Country_name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public Country()
        {
            Films = new List<Film>();
        }

    }
}