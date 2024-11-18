using MovieService.Models;

namespace MovieService.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        void IMovieRepository.CreateMovie(CreateMovieItem createMovieItem)
        {
            throw new NotImplementedException();
        }

        void IMovieRepository.EditMovie(EditMovieItem editMovieItem)
        {
            throw new NotImplementedException();
        }

        void IMovieRepository.DeleteMovie(DeleteMovieItem deleteMovieItem)
        {
            throw new NotImplementedException();
        }

        List<MovieItem> IMovieRepository.GetAllMovies()
        {
            throw new NotImplementedException();
        }
    }
}
