using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Timur.Models
{
    public class TimurContext : DbContext
    {
        public TimurContext() : base("TimurZXCContext") { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Bill> Bills { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}