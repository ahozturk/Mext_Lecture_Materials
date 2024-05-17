using Spovify.Domain;

namespace Spovify.Application;

public class UpdateSongDto
{
    public string Name { get; set; }
    public Artist Artist { get; set; }
    public Producer Producer { get; set; }
}
