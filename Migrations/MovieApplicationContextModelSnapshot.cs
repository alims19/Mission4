﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    partial class MovieApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Category = "Sci-fi/Adventure",
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = (ushort)2014
                        },
                        new
                        {
                            ApplicationId = 2,
                            Category = "Crime/Drama",
                            Director = "Todd Phillips",
                            Edited = false,
                            LentTo = "Ali",
                            Notes = "Joaquin Phoenix slays",
                            Rating = "R",
                            Title = "Joker",
                            Year = (ushort)2019
                        },
                        new
                        {
                            ApplicationId = 3,
                            Category = "Family/Fantasy",
                            Director = "Tim Burton",
                            Edited = true,
                            LentTo = "Prof. Hilton",
                            Notes = "Twisted but awesome",
                            Rating = "PG",
                            Title = "Charlie and the Chocolate Factory",
                            Year = (ushort)2005
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
