using Spovify.Domain;

namespace Spovify.Application;

public class AddSongDto
{
    public string Name { get; set; }
    public Artist Artist { get; set; }
    public Producer Producer { get; set; }
}
