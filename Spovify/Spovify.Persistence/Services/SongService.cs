using Spovify.Application;
using Spovify.Domain;

namespace Spovify.Persistence;

public class SongService : ISongService
{
    private readonly SpovifyDbContext _context;

    public SongService(SpovifyDbContext context)
    {
        _context = context;
    }

    public void Add(AddSongDto addSongDto)
    {
        var newSong = new Song()
        {
            Name = addSongDto.Name,
            Artist = addSongDto.Artist,
            Producer = addSongDto.Producer
        };

        _context.Songs.Add(newSong);

        _context.SaveChanges();
    }

    public List<GetSongDto> List()
    {
        var data = _context.Songs
            .Select(x => new GetSongDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ArtistName = x.Artist.Name,
                    ProducerName = x.Producer.Name
                }).ToList();

        return data;
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Update(Guid id, UpdateSongDto updateSongDto)
    {
        throw new NotImplementedException();
    }
}
