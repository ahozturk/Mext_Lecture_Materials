using TrollifySound.Application.Dtos;
using TrollifySound.Application.RequestParameters;

namespace TrollifySound.Application.Services;

public interface MusicService
{
    Task AddAsync(AddMusicDto music);
    Task<ICollection<GetMusicDto>> GetAllAsync(Pagination pagination);
    Task<GetMusicDto> GetByIdAsync(Guid id);
    Task UpdateAsync(Guid id, UpdateMusicDto music);
    Task DeleteAsync(Guid id);
}