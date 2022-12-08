using TvMaze.Web.Models;

namespace TvMaze.Web.Managers.Interfaces
{
    public interface IShowManager
    {
        Task<Root> GetShowResultsAsync();
    }
}
