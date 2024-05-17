namespace Spovify.Application;

public class GetSongDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ArtistName { get; set; }
    public string ProducerName { get; set; }
}
