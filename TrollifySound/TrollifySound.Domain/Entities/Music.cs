using TrollifySound.Domain.Common;
using TrollifySound.Domain.Entities;

namespace TrollifySound.Domain.Entities;

public class Music : EntityBase
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string ThumbnailUrl { get; set; }
}
