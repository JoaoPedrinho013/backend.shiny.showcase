using Domain.Common;

namespace Domain.Entities;

public class Player : BaseEntity
{
    public required string Name { get; set; }

    public virtual List<Catches> Catches { get; set; } = [];
}