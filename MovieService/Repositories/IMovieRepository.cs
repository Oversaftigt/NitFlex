using MovieService.Models;

namespace MovieService.Repositories
{
    public interface IMovieRepository
    {
        void CreateMovie(CreateMovieItem createMovieItem);
        void EditMovie(EditMovieItem editMovieItem);
        void DeleteMovie(DeleteMovieItem deleteMovieItem);
        List<MovieItem> GetAllMovies();
    }
}
