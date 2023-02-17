class Address
{
    protected string _street, _city, _state, _country, _address;
    protected bool _usa;
    public string DisplayAddress()
    {
        _usa = true;
        Console.Write("What is the street address? ");
        _street = Console.ReadLine();

        Console.Write("What is the City? ");
        _city = Console.ReadLine();

        Console.Write("What is the State/Province & Zip Code? ");
        _state = Console.ReadLine();

        Console.Write("What is the country? ");
        _country = Console.ReadLine();

        if (_country != "USA")
        {
            _usa = false;
        }

        _address = _street + _city + _state + _country;

        Console.WriteLine(string.Format("{0}", _street));
        Console.WriteLine(string.Format("{0}, {1}", _city, _state));
        Console.WriteLine(string.Format("{0}", _country));

        return _address;
    }
    public bool GetCountry()
    {
        return _usa;
    }
}


//Address
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together 
// in one string (with newline characters where appropriate)