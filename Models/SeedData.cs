using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("10-12-2014"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 7.99M,
                        Image = "https://m.media-amazon.com/images/M/MV5BMjE2MzgzMjY0OF5BMl5BanBnXkFtZTgwNDMyMjA2MjE@._V1_SY1000_CR0,0,772,1000_AL_.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-04-12"),
                        Genre = "Biography",
                        Rating = "PG",
                        Price = 8.99M,
                        Image = "https://m.media-amazon.com/images/M/MV5BNjA0NTY1NzM2MV5BMl5BanBnXkFtZTgwMzgyMzYzNTE@._V1_UX182_CR0,0,182,268_AL_.jpg"
                    },

                    new Movie
                    {
                        Title = "The R.M",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 5.99M,
                        Image = "https://m.media-amazon.com/images/M/MV5BMTcyMTUyODAyM15BMl5BanBnXkFtZTYwMDc1NDk5._V1_UX182_CR0,0,182,268_AL_.jpg"
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2005-12-1"),
                        Genre = "Historical",
                        Rating = "NA",
                        Price = 3.99M,
                        Image = "https://m.media-amazon.com/images/M/MV5BOWExNDMzYmItYWU4ZS00MDFlLWIwNGItNzRlMGEzYmZlMGNmXkEyXkFqcGdeQXVyMjgxNTEyNDQ@._V1_UX182_CR0,0,182,268_AL_.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}