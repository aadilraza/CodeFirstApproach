﻿// <auto-generated />
using System;
using CodeFirstApproach;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApproach.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirstApproach.Model.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Course Details");
                });

            modelBuilder.Entity("CodeFirstApproach.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Of_Birth")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DOB")
                        .HasColumnType("DateTime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .HasColumnName("Student Name");

                    b.HasKey("StudentId");

                    b.ToTable("Student Profile");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Date_Of_Birth = new DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local).AddTicks(6464),
                            Name = "William"
                        },
                        new
                        {
                            StudentId = 2,
                            Date_Of_Birth = new DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local).AddTicks(6464),
                            Name = "Henry"
                        },
                        new
                        {
                            StudentId = 3,
                            Date_Of_Birth = new DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local).AddTicks(6464),
                            Name = "Messi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
