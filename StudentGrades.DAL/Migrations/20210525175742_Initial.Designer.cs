﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentGrades.DAL;

namespace StudentGrades.DAL.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20210525175742_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("StudentGrades.DAL.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OwnerId = 1,
                            Value = 3
                        },
                        new
                        {
                            Id = 2,
                            OwnerId = 1,
                            Value = 1
                        },
                        new
                        {
                            Id = 3,
                            OwnerId = 1,
                            Value = 4
                        },
                        new
                        {
                            Id = 4,
                            OwnerId = 2,
                            Value = 3
                        },
                        new
                        {
                            Id = 5,
                            OwnerId = 2,
                            Value = 2
                        },
                        new
                        {
                            Id = 6,
                            OwnerId = 2,
                            Value = 5
                        });
                });

            modelBuilder.Entity("StudentGrades.DAL.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2005, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Teszt Elek",
                            PhoneNumber = 36206547654L,
                            Year = 6
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2006, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bádog Béla",
                            PhoneNumber = 36206526594L,
                            Year = 4
                        });
                });

            modelBuilder.Entity("StudentGrades.DAL.Entities.Grade", b =>
                {
                    b.HasOne("StudentGrades.DAL.Entities.Student", "Owner")
                        .WithMany("Grades")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("StudentGrades.DAL.Entities.Student", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
