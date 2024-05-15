using EventListApp.Domain;
using EventListApp.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventListAppDbContext _context;

        public EventsController(EventListAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Events.Include(x => x.Owner));
        }

        [HttpPost]
        public IActionResult Add(AddEventDto addEventDto)
        {
            var ownerPerson = _context.People.FirstOrDefault(x => x.Id == addEventDto.PersonId);

            if (ownerPerson is null)
                return NotFound("Owner person not found");
            
            Event newEvent = new()
            {
                Id = Guid.NewGuid(),
                Title = addEventDto.Title,
                Description = addEventDto.Description,
                Date = addEventDto.EventDate,
                Owner = ownerPerson,
            };

            _context.Events.Add(newEvent);

            _context.SaveChanges();

            return Ok(newEvent.Id);
        }
    }
}
