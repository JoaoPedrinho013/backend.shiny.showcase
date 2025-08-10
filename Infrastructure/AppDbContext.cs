/*
Esse usa primary constructor, e um exemplo mais moderno que faz o mesmo
*/
using Microsoft.EntityFrameworkCore; // AQUI TRAS DBSET DBCONTEXT MODELBUILDER E ALGUNS METODOS
using Domain.Entities;
using Application.Interfaces;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), IAppDbContext
{
    public DbSet<Player> Players { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Catch> Catches { get; set; }

    public async Task<int> SaveChangesAsync()
    {
       return await base.SaveChangesAsync();
    }
}

