using Application.Dtos;

namespace Application.Interfaces;

public interface IPlayerRepository
{
    Task Create(PlayerCreateRequestDto request);
    Task<bool> Update(int id, PlayerCreateRequestDto request);
}
