using Etickets_.Data.Base;
using Etickets_.Models;
using Etickets_.ViewModel.Data.Enum;
using Etickets_.ViewModel.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Etickets_.Data.services
{
    public interface IMovie : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
