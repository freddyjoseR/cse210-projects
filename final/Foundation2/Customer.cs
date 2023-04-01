class Customer
{
    private string _name;
    private string _country;

    public void SetCustomerName()
    {
        string customerName = Console.ReadLine();

        _name = customerName;
    }
    public void GetCustomerAddress(string address)
    {
        if(address == "1")
        {
            address = "USA";
            _country = address;
        }
        else
        {
            address = "Abroad";
            _country = address;
        }

        
    }

}