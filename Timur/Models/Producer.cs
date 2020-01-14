using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Producer_name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public Producer()
        {
            Films = new List<Film>();
        }

    }
}