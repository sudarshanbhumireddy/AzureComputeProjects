﻿// <auto-generated />
using AzureComputeWindows.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AzureComputeWindows.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240225062620_SeedDataMigration")]
    partial class SeedDataMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AzureComputeWindows.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            CourseName = "IT",
                            Rating = 4.7999999999999998
                        },
                        new
                        {
                            CourseID = 2,
                            CourseName = "HR",
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            CourseID = 3,
                            CourseName = "PayRoll",
                            Rating = 4.5999999999999996
                        },
                        new
                        {
                            CourseID = 4,
                            CourseName = "Az204",
                            Rating = 4.9000000000000004
                        },
                        new
                        {
                            CourseID = 5,
                            CourseName = "Az500",
                            Rating = 4.7999999999999998
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
