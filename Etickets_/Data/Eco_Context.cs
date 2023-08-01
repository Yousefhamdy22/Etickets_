using Etickets_.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Etickets_.Data
{
    public class Eco_Context : DbContext 
    {


        public Eco_Context(DbContextOptions<Eco_Context> options) : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_MOvie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_MOvie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(
                m => m.MovieId);

            modelBuilder.Entity<Actor_MOvie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(
                m => m.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<producer> Producers { get; set; }
        public DbSet<Actor_MOvie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }



        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
     
    }
}
