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

        //Seeded data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Sci-fi/Adventure",
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
                    Category = "Crime/Drama",
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
                    Category = "Family/Fantasy",
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
