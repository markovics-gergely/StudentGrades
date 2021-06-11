using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentGrades.DAL.Entities;
using System;
using System.Diagnostics;

namespace StudentGrades.DAL
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite(@"DataSource=:memory:")
                    .LogTo(m => Debug.WriteLine(m), LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Student>().HasData(
                    new Student() { 
                        Id = 1, 
                        Name = "Teszt Elek",
                        Year = 6,
                        BirthDate = DateTime.Parse("2005/2/4"),
                        PhoneNumber = "36206547654"
                    },
                    new Student() { 
                        Id = 2, 
                        Name = "Bádog Béla",
                        Year = 4,
                        BirthDate = DateTime.Parse("2006/7/1"),
                        PhoneNumber = "36206526594"
                    },
                    new Student()
                    {
                        Id = 3,
                        Name = "Kala Pál",
                        Year = 5,
                        BirthDate = DateTime.Parse("2003/2/11"),
                        PhoneNumber = "36207629921"
                    }
                );

            modelBuilder.Entity<Grade>().HasData(
                    new Grade()
                    {
                        Id = 1,
                        OwnerId = 1,
                        Value = 3
                    },
                    new Grade()
                    {
                        Id = 2,
                        OwnerId = 1,
                        Value = 1
                    },
                    new Grade()
                    {
                        Id = 3,
                        OwnerId = 1,
                        Value = 4
                    },
                    new Grade()
                    {
                        Id = 4,
                        OwnerId = 2,
                        Value = 3
                    },
                    new Grade()
                    {
                        Id = 5,
                        OwnerId = 2,
                        Value = 2
                    },
                    new Grade()
                    {
                        Id = 6,
                        OwnerId = 2,
                        Value = 5
                    }
                );

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Grades)
                .WithOne(g => g.Owner);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
