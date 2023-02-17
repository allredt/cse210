class Customer
{
    protected string _name;
    protected bool _usa;
        public string display()
        {
            Console.Write("Name: ");
            _name = Console.ReadLine();

            return _name;
        }
        public bool usa()
        {
            _usa = true;
            Address address = new Address();
            address.DisplayAddress();

            if (address.GetCountry() != true)
            {
                Console.Write("Not usa");
                _usa = false;
            }
            return _usa;
        }
}


// Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. 
//(Hint this should call a method on the address to find this.)