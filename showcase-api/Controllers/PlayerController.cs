using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace showcase_api.Controllers;

[ApiController]
[Route("[Controller]")]
public class PlayerController(IPlayerRepository playerRepositoy) : ControllerBase
{
    [HttpPost(Name = "CreatePlayer")]
    public void Create([FromBody] PlayerCreateRequestDto request)
    {
        playerRepositoy.Create(request);
    }
}