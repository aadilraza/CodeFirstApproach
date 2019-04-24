using CodeFirstApproach.Configuration;
using CodeFirstApproach.Migrations;
using CodeFirstApproach.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ProjectConfiguration.ConStr);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(b => b.Date_Of_Birth)
                .HasDefaultValueSql("getdate()");



            ModelBuilderExtensions.Seed(modelBuilder);
        }
    }
}
