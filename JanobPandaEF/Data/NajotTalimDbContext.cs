using Microsoft.EntityFrameworkCore;

namespace JanobPandaEF
{
    internal class NajotTalimDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Constants.NT_CONNECTION_STRING);
        }

    }
}