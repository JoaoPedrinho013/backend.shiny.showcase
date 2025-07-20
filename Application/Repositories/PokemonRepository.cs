using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Repositories;

public class PokemonRepository : IPokemonRepository
{
    public void Create(PokemonCreateRequestDto request)
    {
        //validar se existe nome, gif e reigoes, tbm validar se ja nao tem criado no banco de dados
        //condicoes ifs da vida no request e no banco para nao gerar duplicidades
        //preparar
        var pokemon = new Pokemon
        {
            Name = request.Name,
            GifName = request.GifName,
            Regions = request.Regions

        };
        //persistir
        // sql.pokemon.oracle

    }
}