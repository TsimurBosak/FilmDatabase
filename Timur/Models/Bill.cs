using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public string Card_number { get; set; }
        public decimal Balance { get; set; }
        public User User { get; set; }

    }
}