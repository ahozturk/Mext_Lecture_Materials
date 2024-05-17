﻿namespace Spovify.Application;

public interface ISongService
{
    void Add(AddSongDto addSongDto);
    List<GetSongDto> List();
    void Update(Guid id, UpdateSongDto updateSongDto);
    void Delete(Guid id);
}