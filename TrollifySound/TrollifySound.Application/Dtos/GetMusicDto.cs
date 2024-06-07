namespace TrollifySound.Application;

public class GetMusicDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string ThumbnailUrl { get; set; }
    public bool IsDeleted { get; set; }
}
