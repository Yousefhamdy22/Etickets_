using Etickets_.Data.Enum;
using Etickets_.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Etickets_.Data
{
    public class App_Dbinitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        { // to send data in DB OR get data from DB
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var Context = servicescope.ServiceProvider.GetService<Eco_Context>();

                Context.Database.EnsureCreated();


                //Cinema
                if (!Context.Cinemas.Any())
                {
                    Context.Cinemas.AddRange(new List<Cinema>()
                {
                    new Cinema()
                    {
                        Name = "Cinema 1",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 2",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 3",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 4",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 5",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                });
                    Context.SaveChanges();
                }
                //Actor
                if (!Context.Actors.Any())
                {
                    Context.Actors.AddRange(new List<Actor>()
                {
                    new Actor()
                    {
                        FullName = "Actor 1",
                        Bio = "This is the Bio of the first actor",
                       Profilepicitureurl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                    },
                    new Actor()
                    {
                        FullName = "Actor 2",
                        Bio = "This is the Bio of the second actor",
                       Profilepicitureurl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 3",
                        Bio = "This is the Bio of the second actor",
                      Profilepicitureurl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 4",
                        Bio = "This is the Bio of the second actor",
                       Profilepicitureurl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 5",
                        Bio = "This is the Bio of the second actor",
                      Profilepicitureurl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                    }
                });
                    Context.SaveChanges();
                }
                //producer

                if (!Context.Producers.Any())
                {
                    Context.Producers.AddRange(new List<producer>()
                {
                    new producer()
                    {
                        FullName = "Producer 1",
                        Bio = "This is the Bio of the first actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                    },
                    new producer()
                    {
                        FullName = "Producer 2",
                        Bio = "This is the Bio of the second actor",
                         ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                    },
                    new producer()
                    {
                        FullName = "Producer 3",
                        Bio = "This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                    },
                    new producer()
                    {
                        FullName = "Producer 4",
                        Bio = "This is the Bio of the second actor",
                         ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                    },
                    new producer()
                    {
                        FullName = "Producer 5",
                        Bio = "This is the Bio of the second actor",
                         ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                    }
                });
                    Context.SaveChanges();

                }
                //Movie

                if (!Context.Movies.Any())
                {
                    Context.Movies.AddRange(new List<Movie>()
                {
                    new Movie()
                    {
                        Name = "Life",
                        Description = "This is the Life movie description",
                        Price = 39,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(10),
                        CinemaId = 3,
                        ProducerId = 3,
                        Movecategory = Movecategory.Animy
                    },
                    new Movie()
                    {
                        Name = "The Shawshank Redemption",
                        Description = "This is the Shawshank Redemption description",
                        Price = 29,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(3),
                        CinemaId = 1,
                       ProducerId = 1,
                       

                       Movecategory = Movecategory.comedy 
                    },
                    new Movie()
                    {
                        Name = "Ghost",
                        Description = "This is the Ghost movie description",
                        Price = 39,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7),
                        CinemaId = 4,
                        ProducerId = 4,
                        Movecategory = Movecategory.documentry
                    },
                    new Movie()
                    {
                        Name = "Race",
                        Description = "This is the Race movie description",
                        Price = 39,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-5),
                        CinemaId = 1,
                        ProducerId = 2,
                       Movecategory = Movecategory.Action
                    },
                    new Movie()
                    {
                        Name = "Scoob",
                        Description = "This is the Scoob movie description",
                        Price = 39,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 3,
                       Movecategory = Movecategory.Carton
                    },
                    new Movie()
                    {
                        Name = "Cold Soles",
                        Description = "This is the Cold Soles movie description",
                        Price = 39,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                        StartDate = DateTime.Now.AddDays(3),
                        EndDate = DateTime.Now.AddDays(20),
                        CinemaId = 1,
                        ProducerId = 5,
                        Movecategory = Movecategory.Drama
                    }
                });
                    Context.SaveChanges();

                }


                //Actor & Movie
                if (!Context.Actors_Movies.Any())
                {

                    Context.Actors_Movies.AddRange(new List<Actor_MOvie>()
                    {
                        new Actor_MOvie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_MOvie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_MOvie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_MOvie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_MOvie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_MOvie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_MOvie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_MOvie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                   Context.SaveChanges();
                }


            }
        }
    }
}