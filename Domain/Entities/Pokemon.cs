using Domain.Common;

namespace Domain.Entities;

public class Pokemon : BaseEntity
{
    public required string Name { get; set; }
    public string? GifName { get; set; }
    public List<PokemonRegion> Regions { get; set; } = [];
}