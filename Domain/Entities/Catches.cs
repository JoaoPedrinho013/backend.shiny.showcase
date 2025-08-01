using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Catches : BaseEntity
{
    public int PlayerId { get; set; }
    public virtual Player Player { get; set; } = default!;

    public int PokemonId { get; set; }
    public virtual Pokemon Pokemon { get; set; } = default!;

    public int Encounter { get; set; }
    public DateTime CatchDate { get; set; }
    public CatchMethod CatchMethod { get; set; }
    public ShinyStatus ShinyStatus { get; set; }
    public bool IsRare { get; set; }
}