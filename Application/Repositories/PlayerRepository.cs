using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Repositories;

public class PlayerRepository : IPlayerRepository
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
    // public void Update(PlayerCreateRequestDto request)
    // {
    //     //validar se existe nome e verificar se ja nao esta criado no banco de dados

    //     //preparar
    //     //receber um id e trocar o name dele pelo name

    //     //persistir no banco de dados
    // }
}