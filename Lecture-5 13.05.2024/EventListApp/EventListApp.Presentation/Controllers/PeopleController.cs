using EventListApp.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly EventListAppDbContext _context;

        public PeopleController(EventListAppDbContext context)
        {
            _context = context;
        }
    }
}
