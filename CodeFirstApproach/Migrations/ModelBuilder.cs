using CodeFirstApproach.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Migrations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "William", Date_Of_Birth = DateTime.Now },
                new Student { StudentId = 2, Name = "Henry", Date_Of_Birth = DateTime.Now },
                new Student { StudentId = 3, Name = "Messi", Date_Of_Birth = DateTime.Now }
            );

            //DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local)
        }
    }
}
