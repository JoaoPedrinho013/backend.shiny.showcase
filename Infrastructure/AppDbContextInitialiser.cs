using Microsoft.EntityFrameworkCore; // AQUI TRAS DBSET DBCONTEXT MODELBUILDER E ALGUNS METODOS
using Domain.Entities; //IMPORTAR ENTIDADES

public class AppDbContextInitialiser(AppDbContext context)
{
    public async Task InitialiseAsync()
    {
        try
        {
            if (context.Database.IsNpgsql())
            {
                await context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}

