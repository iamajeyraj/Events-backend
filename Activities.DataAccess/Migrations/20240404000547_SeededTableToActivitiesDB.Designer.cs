﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Activities.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240404000547_SeededTableToActivitiesDB")]
    partial class SeededTableToActivitiesDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Activities.Model.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("15b41588-04c9-469c-ac8e-7ccc99df3698"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 2, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5230),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("676b34fb-93ad-49f4-b340-ac9bad31bdbc"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2024, 3, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5240),
                            Description = "Activity 1 month ago",
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("655dd466-bee1-4304-8074-d0a682888af3"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2024, 5, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5250),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("0217a480-d818-4c48-82c0-8b0df16c530a"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2024, 6, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5250),
                            Description = "Activity 2 months in future",
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("e276c6af-62d6-4e08-8896-b1525a267894"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 7, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5260),
                            Description = "Activity 3 months in future",
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("d4048f4d-1109-4a7b-80ee-cbe230ff3b38"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 8, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5270),
                            Description = "Activity 4 months in future",
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("acb59ef5-d014-43f8-b22e-f328f9734c9e"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2024, 9, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5270),
                            Description = "Activity 5 months in future",
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("c066f421-e670-4eac-8a6c-8d87b3c373ea"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2024, 10, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5280),
                            Description = "Activity 6 months in future",
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("c6ed323f-6e34-454c-bbcd-41c8c9ff8bb8"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2024, 11, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5290),
                            Description = "Activity 2 months ago",
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("455b6112-ddf9-4827-b561-ab2607509f05"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2024, 12, 4, 0, 5, 47, 742, DateTimeKind.Utc).AddTicks(5290),
                            Description = "Activity 8 months in future",
                            Title = "Future Activity 8",
                            Venue = "Cinema"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}