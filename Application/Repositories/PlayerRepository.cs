using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class PlayerRepository(IAppDbContext dbContext) : IPlayerRepository
{
    public async Task Create(PlayerCreateRequestDto request)
    {
        //validar se existe nome e verificar se ja nao esta criado no banco de dados

        //preparar
        var player = new Player
        {
            Name = request.Name
        };

        dbContext.Players.Add(player);
        await dbContext.SaveChangesAsync();

        //persistir no banco de dados
    }
    public async Task<bool> Update(int id, PlayerCreateRequestDto request)//id do player e os dados vindo do front, aqui so o nome msm 
    {
        var player = await dbContext.Players
            .FirstOrDefaultAsync(player => player.Id == id); // procurando o player dentro do banco de dados se n achar volta null 

        if (player == null)
            return false; // o return e pra ja sair pq nao achou, devez continuar 

        player.Name = request.Name; // aqui ja e padrao somente seta e salva em baixo, depois retorna true

        await dbContext.SaveChangesAsync();
        return true;
    }

}
