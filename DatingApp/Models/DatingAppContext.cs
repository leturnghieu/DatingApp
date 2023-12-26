using Microsoft.EntityFrameworkCore;

namespace DatingApp.Models
{
    public class DatingAppContext : DbContext
    {
        public DatingAppContext()
        {

        }
        public DatingAppContext(DbContextOptions<DatingAppContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S3J7HQV\\SQLEXPRESS;Database=DatingApp;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
