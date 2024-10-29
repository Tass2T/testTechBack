using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using testTechBack.Infrastructure.Repositories;

namespace testTechBack.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        public IResult getPlayers ([FromServices] IPlayersRepository playersRepository) 
        {
            var players = playersRepository.GetAllPlayers();

            return Results.Ok(players.OrderByDescending(o => o.Data.Rank));
        }

        [HttpGet("{id}")]
        public IResult getPlayerById ([FromServices] IPlayersRepository playersRepository, [FromRoute] int id)
        {
            var player = playersRepository.GetPlayerById(id);
            if (player == null) return Results.NotFound();
            
            return Results.Ok(player); 
        }
    }
}

