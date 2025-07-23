using Application.Dtos;

namespace Application.Interfaces;

public interface IPokemonRepository
{
    /// <summary>
    /// Esse método é responsável por criar um Player
    /// </summary>
    /// <param name="request">Esse parâmetro são os dados necessário para criar um player</param>
    void Create(PokemonCreateRequestDto request);
}