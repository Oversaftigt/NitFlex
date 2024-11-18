using MovieService.Models;

namespace MovieService.Services
{
    public class MovieService : IMovieService
    {
        void IMovieService.CreateMovie(CreateMovieItem createMovieItem)
        {
            throw new NotImplementedException();
        }

        void IMovieService.EditMovie(EditMovieItem editMovieItem)
        {
            throw new NotImplementedException();
        }

        void IMovieService.DeleteMovie(DeleteMovieItem deleteMovieItem)
        {
            throw new NotImplementedException();
        }

        List<MovieItem> IMovieService.GetAllMovies()
        {
            throw new NotImplementedException();
        }
    }
}
