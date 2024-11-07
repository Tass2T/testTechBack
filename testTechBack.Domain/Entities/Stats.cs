using System;

namespace testTechBack.Domain.Entities;

public class Stats
{
    public string CountryWithMoreWins {get; set;} = String.Empty;
    public List<MBIData> AverageBMIPerPlayer {get; set;}
    public int Medians {get; set;}

   public Stats (string country, List<MBIData> BMI, int medians)
   {
        CountryWithMoreWins = country;
        AverageBMIPerPlayer = BMI;
        Medians = medians;
   }

}
