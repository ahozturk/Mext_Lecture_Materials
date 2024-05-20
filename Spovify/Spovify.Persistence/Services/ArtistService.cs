using Spovify.Application;
using Spovify.Domain;

namespace Spovify.Persistence;

public class ArtistService : IArtistService
{
    private readonly SpovifyDbContext _context;

    public ArtistService(SpovifyDbContext context)
    {
        _context = context;
    }

    public void Add(AddArtistDto addArtistDto)
    {
        var newArtist = new Artist()
        {
            Name = addArtistDto.Name,
            Surname = addArtistDto.Surname,
            Birthdate = addArtistDto.Birthdate,
            Nick = addArtistDto.Nick
        };

        _context.Artists.Add(newArtist);

        _context.SaveChanges();
    }
}
