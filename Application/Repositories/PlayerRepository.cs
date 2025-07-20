using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Repositories;

public class PlayerRepository : IPlayerRepositoy
{
    public void Create(PlayerCreateRequestDto request)
    {
        //validar se existe nome e verificar se ja nao esta criado no banco de dados

        //preparar
        var player = new Player
        {
            Name = request.Name
        };

        //persistir no banco de dados
    }
}