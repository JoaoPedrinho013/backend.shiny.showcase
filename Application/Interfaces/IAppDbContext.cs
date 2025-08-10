using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IAppDbContext
{
    public DbSet<Player> Players { get; }
    public DbSet<Pokemon> Pokemons { get; }
    public DbSet<Catch> Catches { get; }


    Task<int> SaveChangesAsync ();
}