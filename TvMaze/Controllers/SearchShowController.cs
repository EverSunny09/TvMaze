using Microsoft.AspNetCore.Mvc;
using TvMaze.Web.Managers.Interfaces;
using TvMaze.Web.Models;

namespace TvMaze.Web.Controllers
{
    public class SearchShowController : Controller
    {
        private readonly ILogger<SearchShowController> _logger;
        private readonly IShowManager _showManager;

        public SearchShowController(ILogger<SearchShowController> logger, IShowManager showManager)
        {
            _logger = logger;
            _showManager = showManager;
        }
        public async Task<ActionResult> Index()
        {
            var getShowDetails = await _showManager.GetShowResultsAsync();
            return View(getShowDetails);
        }
    }
}
