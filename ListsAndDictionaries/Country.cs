namespace ListsAndDictionaries;

internal class Country
{
    public string Name { get; set; }
    public string CountryCode { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is not Country country)
            return false;


        return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase) &&
               this.CountryCode.Equals(country.CountryCode, StringComparison.OrdinalIgnoreCase);

    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Name, this.CountryCode);
    }

    public override string ToString()
    {
        return $"Country: {Name,-10}, ISO Code: {CountryCode}";
    }

}
