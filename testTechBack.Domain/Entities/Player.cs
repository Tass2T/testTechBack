using System;

namespace testTechBack.Domain.Entities;

public class Player
{
    public int Id {get; set;}
    public string Firstname {get; set;} = String.Empty;

    public string Lastname {get; set;} = String.Empty;

    public string Sex {get; set;} = String.Empty;

    public Country Country {get; set;} = default!;

    public PlayerData Data {get; set;} = default!;
   
}