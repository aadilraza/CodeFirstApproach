﻿// <auto-generated />
using System;
using CodeFirstApproach;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApproach.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20190424134221_ThirdCreate")]
    partial class ThirdCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasDefaultValue(new DateTime(2019, 4, 24, 18, 42, 20, 704, DateTimeKind.Local).AddTicks(724));

                    b.Property<string>("Name")
                        .HasColumnName("Student Name");

                    b.HasKey("StudentId");

                    b.ToTable("Student Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
