using Spovify.Domain;

namespace Spovify.Application;

public class AddSongDto
{
    public string Name { get; set; }
    public Guid ArtistId { get; set; }
    public Guid ProducerId { get; set; }
}
