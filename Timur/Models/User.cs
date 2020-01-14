using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Timur.Models
{
    public class User
    {
        public int Id { get; set; }
        public string User_picture { get; set; }
        [Required]
        public string Password { get; set; }
        public string Login { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public User()
        {
            Bills = new List<Bill>();
            Films = new List<Film>();
        }
    }
}