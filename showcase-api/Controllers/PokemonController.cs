using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace showcase_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController(IPokemonRepository pokemonRepository) : ControllerBase
{
    [HttpPost(Name = "CreatePokemon")]
    public void Create([FromBody] PokemonCreateRequestDto request)
    {
        pokemonRepository.Create(request);
    }
}