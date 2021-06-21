using System;
using System.Collections.Generic;
using System.Text;
using ECinema.Web.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECinema.Web.Models.DomainModels;

namespace ECinema.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ECinemaApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        public  virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<ActorsInMovies> actorsInMovies { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Ticket>().Property(z => z.Id).ValueGeneratedOnAdd();

            builder.Entity<Movie>().Property(z => z.Id).ValueGeneratedOnAdd();

            builder.Entity<Actor>().Property(z => z.Id).ValueGeneratedOnAdd();

            builder.Entity<ActorsInMovies>().HasKey(z => new { z.ActorId, z.MovieId });



            builder.Entity<Ticket>().HasOne(z => z.movie).WithMany(z => z.Tickets);

            builder.Entity<Movie>().HasMany(z => z.ActorsInMovies).WithOne(z => z.movie);

            builder.Entity<Movie>().HasMany(z => z.Tickets).WithOne(z => z.movie);

            builder.Entity<ActorsInMovies>().HasOne(z => z.movie).WithMany(z => z.ActorsInMovies).HasForeignKey(z=>z.MovieId);


            builder.Entity<ActorsInMovies>().HasOne(z => z.actor).WithMany(z => z.ActorsInMovies).HasForeignKey(z=>z.ActorId);
            



        }
    }
}
