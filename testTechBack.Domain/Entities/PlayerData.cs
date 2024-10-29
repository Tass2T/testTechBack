using System;

namespace testTechBack.Domain.Entities;

public class PlayerData
{
    public int Rank {get; set;}
    public int Points {get; set;}

    public int Weight {get; set;}

    public int Height {get; set;}

    public int Age {get; set;}

    public List<int> Last {get; set;} = [];

    public PlayerData (int rank, int points, int weight, int height, int age, List<int> last) {
        Rank = rank;
        Points = points;
        Weight = weight;
        Height = height;
        Age = age;
        Last = last;
    }
}