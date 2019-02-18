using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Data
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> producers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Producer>().ToTable("Producer");
        }
    }
}

