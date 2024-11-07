using System;
using testTechBack.Domain.Entities;

namespace testTechBack.Infrastructure.Repositories;

public class PlayersRepository : IPlayersRepository
{

    private readonly List<Player> players = [
        new Player( 
            52, "Novak", "Djokovic", "M",
            new Country("SRB", "https://data.latelier.co/training/tennis_stats/resources/Serbie.png"),
            new PlayerData(2, 2542, 80000, 188, 31, new List<int> { 1, 1, 1, 1, 1 })
        ),
        new Player( 
            95, "Venus", "Williams", "F",
            new Country("USA", "https://data.latelier.co/training/tennis_stats/resources/USA.png"),
            new PlayerData(52, 1105, 74000, 185, 38, new List<int> { 0, 1, 0, 0, 1 })
        ),
        new Player(
            65, "Stan", "Wawrinka", "M",
            new Country("SUI", "https://data.latelier.co/training/tennis_stats/resources/Suisse.png"),
            new PlayerData(21, 1784, 81000, 183, 33, new List<int> { 1, 1, 1, 0, 1 })
        ),
        new Player(
            102, "Serena", "Williams", "F",
            new Country("USA", "https://data.latelier.co/training/tennis_stats/resources/USA.png"),
            new PlayerData(10, 3521, 72000, 175, 37, new List<int> { 0, 1, 1, 1, 0 })
        ),
        new Player(
            17, "Rafael", "Nadal", "M",
            new Country("ESP", "https://data.latelier.co/training/tennis_stats/resources/Espagne.png"),
            new PlayerData(1, 1982, 85000, 185, 33, new List<int> { 1, 0, 0, 0, 1 })
        )
    ];
    public List<Player> GetAllPlayers()
    {
        return players;
    }

    public Player? GetPlayerById(int id)
    {
        return players.FirstOrDefault(player => player.Id == id);
    }

    public Stats GetStats()
    {
        var playersListByLastWin = players.OrderByDescending(player => player.Data.Last.Sum()).ToList();
        var playersListBySize = players.OrderBy(player => player.Data.Height).ToList();
        var countryWithMostWins = playersListByLastWin[0].Country.CountryName;

        var nbOfPlayer = players.Count;
        var medianIndex = nbOfPlayer % 2 == 0 ? ((nbOfPlayer / 2) + 1) : ((nbOfPlayer + 1) / 2);
        var medianSize = playersListBySize[medianIndex - 1].Data.Height;

        return new Stats(countryWithMostWins, [], medianSize);

    }
}
