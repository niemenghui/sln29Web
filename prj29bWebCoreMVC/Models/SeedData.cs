﻿using Microsoft.EntityFrameworkCore;
using prj29bWebCoreMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace prj29bWebCoreMVC.Models
{
	public static class SeedData
	{

		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new prj29bWebCoreMVCContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<prj29bWebCoreMVCContext>>()))
			{
				// Look for any movies.
				if (context.Movie.Any())
				{
					return;   // DB has been seeded
				}
				context.Movie.AddRange(
					new Movie
					{
						Title = "When Harry Met Sally1",
						ReleaseDate = DateTime.Parse("1989-2-12"),
						Genre = "Romantic Comedy",
						Price = 7.99M
					},
					new Movie
					{
						Title = "Vacation to Paris2 ",
						ReleaseDate = DateTime.Parse("1984-3-13"),
						Genre = "Comedy",
						Price = 8.99M
					},
					new Movie
					{
						Title = "Mr. Bean 3",
						ReleaseDate = DateTime.Parse("1986-2-23"),
						Genre = "Comedy",
						Price = 9.99M
					},
					new Movie
					{
						Title = "Hero4 Bravo",
						ReleaseDate = DateTime.Parse("1959-4-15"),
						Genre = "Western",
						Price = 3.99M
					}
				);
				context.SaveChanges();
			}
		}
	}
}