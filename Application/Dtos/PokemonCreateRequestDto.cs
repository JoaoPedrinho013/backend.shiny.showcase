using Domain.Enums;

namespace Application.Dtos;

public class PokemonCreateRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string? GifName { get; set; }
    public List<PokemonRegion> Regions { get; set; } = [];


}