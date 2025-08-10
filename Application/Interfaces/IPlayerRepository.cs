using Application.Dtos;

namespace Application.Interfaces;

public interface IPlayerRepository
{
    Task Create(PlayerCreateRequestDto request);
    // void Update(PlayerCreateRequestDto request);
}