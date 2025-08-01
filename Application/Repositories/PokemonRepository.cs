using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Repositories;

public class PokemonRepository : IPokemonRepository
{
    /// <summary>
    /// Esse método é responsável por criar um Player
    /// </summary>
    /// <param name="request">Esse parâmetro são os dados necessário para criar um player</param>
    public void Create(PokemonCreateRequestDto request)
    {
        //validar se existe nome, gif e reigoes, tbm validar se ja nao tem criado no banco de dados
        //condicoes ifs da vida no request e no banco para nao gerar duplicidades
        //preparar
        var pokemon = new Pokemon
        {
            Name = request.Name,
            GifName = request.GifName,
            // Regions = request.Regions

        };
        //persistir
        // sql.pokemon.oracle

    }
}