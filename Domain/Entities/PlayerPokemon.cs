using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class PlayerPokemon : BaseEntity
{

    public int PlayerId { get; set; }
    public int PokemonId { get; set; }
    public int Encounter { get; set; }
    public DateTime CatchDate { get; set; }
    public List<CatchMethod> CatchMethod { get; set; } = [];
    public List<ShinyStatus> ShinyStatus { get; set; } = [];

}