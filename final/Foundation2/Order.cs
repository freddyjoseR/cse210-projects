class Order
{
    private List<string> _products = new List<string>();
    private string _customer;
    private float _total;
    private int _usShipping = 5;
    private int _abroadShipping = 35;

    public void AddProduct(string product)
    {
        _products.Add(product);
    }

    public void SetCustomer(string customer)
    {
        _customer = customer;
    }
    public void GetOrderCost(float price, int amount)
    {
        
    }

    public void GetPackingLabel()
    {
        
    }

    public void GetShippingLabel()
    {
        
    }
}