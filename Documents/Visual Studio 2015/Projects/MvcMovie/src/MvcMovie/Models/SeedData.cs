﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                 new Movie
                 {
                     Title = "When Harry Met Sally",
                     ReleaseDate = DateTime.Parse("1989-1-11"),
                     Genre = "Romantic Comedy",
                     Rating = "G",
                     Price = 7.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "G",

                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "G",

                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "G",

                   Price = 3.99M
               }


            );
            context.SaveChanges();
        }
    }
}
