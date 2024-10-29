using System;
using testTechBack.Domain.Entities;
namespace testTechBack.Infrastructure.Repositories;

public interface IPlayersRepository
{
    public List<Player> GetAllPlayers();

    public Player? GetPlayerById(int id);
}
