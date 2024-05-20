using Spovify.Domain;

namespace Spovify.Application;

public class AddProducerDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTimeOffset Birthdate { get; set; }
    public Genre Genre { get; set; }
}
