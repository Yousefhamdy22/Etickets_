using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using Etickets_.Data.Base;
using Etickets_.Data.Enum;
using Etickets_.Models;
using Etickets_.ViewModel.Data.Enum;
using Etickets_.ViewModel.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets_.Data.services
{
    public class MoviesSevice : EnitiyBaseRepository<Movie> , IMovie
    {
        private readonly Eco_Context _Context;

       
        public MoviesSevice(Eco_Context context ) : base(context)
        {
            _Context = context;
        }
        //public void AddAsyc(Movie entity)
        //{
        //}

        public async Task AddNewMovieAsync(NewMovieVM data)
        {

            var newMove = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = (decimal)data.Price,
                ImageUrl = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                Movecategory = data.MovieCategory,
                ProducerId = data.ProducerId

            };

            await _Context.AddAsync(newMove);
            await _Context.SaveChangesAsync();


            //Add Movie Actors

            foreach(var actorid in data.ActorIds )
            {
                var newActorMovie = new Actor_MOvie()
                {
                    MovieId = newMove.Id,
                    ActorId = actorid
                };
                await _Context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _Context.SaveChangesAsync();
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDe = await _Context.Movies
                .Include(c => c.Cinema)
                .Include(c => c.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDe;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var respose = new NewMovieDropdownsVM()
            {
                Actors = await _Context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _Context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _Context.Producers.OrderBy(n => n.FullName).ToListAsync(),
            };
            return respose;
        }

        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            var dbMovie =await _Context.Movies.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbMovie != null)
            {
                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description;
                dbMovie.Price = (decimal)data.Price;
                dbMovie.ImageUrl = data.ImageURL;
                dbMovie.CinemaId = data.CinemaId;
                dbMovie.StartDate = data.StartDate;
                dbMovie.EndDate = data.EndDate;
                dbMovie.Movecategory = data.MovieCategory;
                dbMovie.ProducerId = data.ProducerId;
                await _Context.SaveChangesAsync();
            }

            //Remove existing actors
            var existingActorsDb = _Context.Actors_Movies.Where(n => n.MovieId == data.Id).ToList();
            _Context.Actors_Movies.RemoveRange(existingActorsDb);
            await _Context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_MOvie()
                {
                    MovieId = data.Id,
                    ActorId = actorId
                };
                await _Context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _Context.SaveChangesAsync();
        }
    }
}

