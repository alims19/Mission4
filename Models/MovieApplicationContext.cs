using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4.Models
{
    //Constructor
    public class MovieApplicationContext : DbContext
    {
        //Constructor
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {
         
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seeded data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Assigns each category an ID
            mb.Entity<Category>().HasData(
              new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
              new Category { CategoryId = 2, CategoryName = "Comedy" },
              new Category { CategoryId = 3, CategoryName = "Drama" },
              new Category { CategoryId = 4, CategoryName = "Family" }, 
              new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
              new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
              new Category { CategoryId = 7, CategoryName = "Television" },
              new Category { CategoryId = 8, CategoryName = "VHS" }
              );

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 1,
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryId = 5,
                    Title = "Joker",
                    Year = 2019,
                    Director = "Todd Phillips",
                    Rating = "R",
                    Edited = false,
                    LentTo = "Ali",
                    Notes = "Joaquin Phoenix slays"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryId = 4,
                    Title = "Charlie and the Chocolate Factory",
                    Year = 2005,
                    Director = "Tim Burton",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Prof. Hilton",
                    Notes = "Twisted but awesome"
                }
            );
        }
    }
}
