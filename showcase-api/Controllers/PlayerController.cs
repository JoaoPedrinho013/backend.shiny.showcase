using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace showcase_api.Controllers;

[ApiController]
[Route("[Controller]")]
public class PlayerController(IPlayerRepository playerRepository) : ControllerBase
{



    [HttpPost(Name = "CreatePlayer")]
    public async Task Create([FromBody] PlayerCreateRequestDto request)
    {
        await playerRepository.Create(request);
    }



    [HttpPut("{id}", Name = "UpdatePlayer")]
public async Task<IActionResult> Update(int id, [FromBody] PlayerCreateRequestDto request) // id do player e os dados vindo do front, aqui so o nome msm e o IActionResult e do EC que deixa os erros bonitinhos la sem travar a requisicao
{
    var updated = await playerRepository.Update(id, request); // procura no playerRepository, se nao achar retorna false, se achar retorna true
    if (!updated)
        return NotFound($"Player com id {id} não encontrado.");

    return Ok("Player atualizado com sucesso!"); // aqui tem o retorno que usa o IActionResult
}

}