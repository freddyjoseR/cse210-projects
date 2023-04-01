class Product
{
    private string _name;
    private int _idNumber;
    private float _price;
    private int _quantity;

    
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetIDNumber()
    {
        return _idNumber;
    }

    public void SetIDnumber(int idNumber)
    {
        _idNumber = idNumber;
    }
    public float GetPrice()
    {
        return _price;
    }

    public void SetPrice(float price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    
    public int GetQuatity()
    {
        return _quantity;
    }

    public void GetTotalPrice()
    {
        float total = _price * _quantity;
        Console.WriteLine($"The total price of {_quantity} {_name} is {total}");
    }
}