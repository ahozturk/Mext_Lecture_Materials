namespace Spovify.Application;

public interface ISongService
{
    void Add(AddSongDto addSongDto);
    List<GetSongDto> List();
    UpdateSongResponse Update(Guid id, UpdateSongDto updateSongDto);
    DeleteSongResponse Delete(Guid id);
}
