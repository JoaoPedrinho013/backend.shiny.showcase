using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class PokemonRegion : BaseEntity
{
    public Region Region { get; set; } 
    public int Index { get; set; }
}