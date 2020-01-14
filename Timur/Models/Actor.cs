using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Actor_name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public Actor()
        {
            Films = new List<Film>();
        }
    }
}