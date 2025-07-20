using Application.Dtos;

namespace Application.Interfaces;

public interface IPlayerRepositoy
{
    void Create(PlayerCreateRequestDto request);
}