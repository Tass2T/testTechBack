using System;

namespace testTechBack.Domain.Entities;

public class Country
{
    public string CountryName {get; private set;} = String.Empty;
    public string Code {get; private set;} = String.Empty;

    public Country (string country, string code)
    {
        CountryName = country;
        Code = code;
    }
}
