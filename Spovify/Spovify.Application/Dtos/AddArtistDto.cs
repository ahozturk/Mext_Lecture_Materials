namespace Spovify.Application;

public class AddArtistDto
{
    public string Name{ get; set; }
    public string Surname { get; set; }
    public DateTimeOffset Birthdate { get; set; }
    public string Nick { get; set; }
}
