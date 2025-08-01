using Domain.Enums;

namespace Application.Dtos;

public class PokemonCreateRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string? GifName { get; set; }
    public List<Region> Regions { get; set; } = [];


}