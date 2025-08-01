using Application.Dtos;

namespace Application.Interfaces;

public interface IPlayerRepository
{
    void Create(PlayerCreateRequestDto request);
}