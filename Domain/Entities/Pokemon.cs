using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Pokemon : BaseEntity
{
    public required string Name { get; set; }
    public string? GifName { get; set; }
    public List<PokemonRegion> Regions { get; set; } = [];
}