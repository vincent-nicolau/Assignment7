using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public interface IMovieRepo
    {
        IEnumerable<Movie> GetAll();
        Task<IEnumerable<Movie>> GetAllAsync();
        Movie? GetById(int id);
        Task<Movie?> GetByIdAsync(int id);
        IEnumerable<string> GetGenres();
        Task<IEnumerable<string>> GetGenresAsync();
        void Add(Movie movie);
        Task AddAsync(Movie movie);
        void Update(Movie movie);
        bool Exists(int id);
        Task<bool> ExistsAsync(int id);
        void Delete(Movie movie);
        Task SaveAsync();
    }
}
