class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public void SetAddress(string street, string city, string state, string country)
    {
        _street = street;
    }

    public void GetAddress()
    {
        Console.WriteLine($"{_street}, {_city}, {_state}, {_country}");
    }
}