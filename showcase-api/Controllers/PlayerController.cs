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

    // [HttpUpdate(Name = "UpdatePlayer")]
    // public void Update([FromBody] PlayerCreateRequestDto request)
    // {
    //     playerRepository.Update(request);
    // }
}