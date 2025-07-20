using Application.Dtos;

namespace Application.Interfaces;

public interface IPokemonRepository
{
    void Create(PokemonCreateRequestDto request);
}