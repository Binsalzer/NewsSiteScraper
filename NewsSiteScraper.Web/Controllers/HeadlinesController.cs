using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsSiteScraper.Data;

namespace NewsSiteScraper.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadlinesController : ControllerBase
    {
        private readonly string _connection;

        public HeadlinesController(IConfiguration config)
        {
            _connection = config.GetConnectionString("ConStr");
        }

        [HttpGet("getheadlines")]
        public List<Headline> GetHeadlines()
        {
            var repo = new ScraperRepository(_connection);
            return repo.GetHeadlines();
        }
    }
}
