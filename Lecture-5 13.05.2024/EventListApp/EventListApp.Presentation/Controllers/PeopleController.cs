using EventListApp.Domain;
using EventListApp.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.People);
        }

        [HttpPost]
        public IActionResult Add(AddPersonDto addPersonDto)
        {
            Person person = new()
            {
                Id = Guid.NewGuid(),
                Name = addPersonDto.Name,
                PhoneNumber = addPersonDto.PhoneNumber
            };

            _context.People.Add(person);

            _context.SaveChanges();

            return Ok(person.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdatePersonDto updatePersonDto)
        {
            var selectedPerson = await _context.People.FirstOrDefaultAsync(x => x.Id == id);

            if (selectedPerson is null)
                return NotFound("Person not found");

            selectedPerson.Name = updatePersonDto.Name;
            selectedPerson.PhoneNumber = updatePersonDto.PhoneNumber;

            var result = await _context.SaveChangesAsync();

            return Ok("Changes saved");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var selectedPerson = _context.People.FirstOrDefault(x => x.Id == id);

            if (selectedPerson is null)
                return NotFound("Person not found");

            _context.People.Remove(selectedPerson);

            _context.SaveChanges();

            return Ok("Person deleted");
        }
    }
}
