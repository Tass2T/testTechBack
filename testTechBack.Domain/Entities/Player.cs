using System;

namespace testTechBack.Domain.Entities;

public class Player
{
    public int Id {get; private set;}
    public string Firstname {get; private set;} = String.Empty;

    public string Lastname {get; private set;} = String.Empty;

    public string Sex {get; private set;} = String.Empty;

    public Country Country {get; private set;} = default!;

    public PlayerData Data {get; private set;} = default!;

    public Player (int id, string firstname, string lastName, string sex, Country country, PlayerData data)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastName;
        Sex = sex;
        Country = country;
        Data = data;
    }
   
}