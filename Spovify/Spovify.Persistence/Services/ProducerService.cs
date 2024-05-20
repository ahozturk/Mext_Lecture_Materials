using Spovify.Application;
using Spovify.Domain;

namespace Spovify.Persistence;

public class ProducerService : IProducerService
{
    private readonly SpovifyDbContext _context;

    public ProducerService(SpovifyDbContext context)
    {
        _context = context;
    }

    public void Add(AddProducerDto addProducerDto)
    {
        var newProducer = new Producer()
        {
            Name = addProducerDto.Name,
            Surname = addProducerDto.Surname,
            Birthdate = addProducerDto.Birthdate,
            Genre = addProducerDto.Genre
        };

        _context.Producers.Add(newProducer);

        _context.SaveChanges();
    }
}
