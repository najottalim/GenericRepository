using JanobPandaEF.Domain;
using JanobPandaEF.Domain.Service;
using JanobPandaEF.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JanobPandaEF.Data.Contexts
{
    public class NajotTalimDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        // ViewModels
        public virtual DbSet<StudentData> StudentDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Constants.NT_CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MockData
            modelBuilder.Entity<Subject>().HasData(new List<Subject>
            {
                new Subject { Id = 1, Name = ".NET" },
                new Subject { Id = 2, Name = "Java" },
                new Subject { Id = 3, Name = "Go" },
            });

            modelBuilder.Entity<Group>().HasData(new List<Group>
            {
                new Group { Id = 1, Name = "dotNET #1", SubjectId = 1 },
                new Group { Id = 2, Name = "Java #1", SubjectId = 2 },
            });

            modelBuilder.Entity<University>().HasData(new List<University>
            {
                new University { Id = 1, Name = "TUIT", Level = 1, Address = "Tashkent" },
                new University { Id = 2, Name = "WIUT", Level = 2, Address = "Tashkent" },
            });

            modelBuilder.Entity<Student>().HasData(new List<Student>
            {
                new Student { Id = 1, FullName = "Ahmadjon Sirojiddinov", UniversityId = 2, GroupId = 1 },
                new Student { Id = 2, FullName = "Muhammadabdulloh Komilov", UniversityId = 1, GroupId = 2 },
                new Student { Id = 3, FullName = "Abbos Haydarov", UniversityId = 1, GroupId = 1 }
            });
            #endregion

            modelBuilder.Entity<StudentData>().ToFunction("get_data_of_student");
            modelBuilder.Entity<StudentData>().ToTable(nameof(StudentData), p => p.ExcludeFromMigrations(true));
        }

    }
}