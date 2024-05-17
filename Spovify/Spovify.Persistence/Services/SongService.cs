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

    public DeleteSongResponse Delete(Guid id)
    {
        var song = _context.Songs.FirstOrDefault(x => x.Id == id);

        if (song is null)
            return new DeleteSongResponse(false, "Song not found.");

        _context.Songs.Remove(song);

        _context.SaveChanges();

        return new DeleteSongResponse(true);
    }

    public UpdateSongResponse Update(Guid id, UpdateSongDto updateSongDto)
    {
        var song = _context.Songs.FirstOrDefault(x => x.Id == id);

        if (song is null)
            return new UpdateSongResponse(false, "Song not found.");

        song.Name = updateSongDto.Name;
        song.Artist = updateSongDto.Artist;
        song.Producer = updateSongDto.Producer;

        _context.SaveChanges();

        return new UpdateSongResponse(true);
    }
}
