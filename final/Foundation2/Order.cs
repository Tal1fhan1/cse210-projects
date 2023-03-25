public class Order
{
    private List<string> _products = new List<string>();
    private List<int> _prices = new List<int>();
    private string _customer;

    public Order()
    {
    }
    public Order(List<string> products, List<int> prices, string customer)
    {
        _products = products;
        _prices = prices;
        _customer = customer;
    }

    public List<string> GetProducts()
    {
        return _products;
    }
    public void SetProducts(List<string> products)
    {
        _products = products;
    }
    public List<int> GetPrices()
    {
        return _prices;
    }
    public void SetPrices(List<int> prices)
    {
        _prices = prices;
    }
    public string GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(string customer)
    {
        _customer = customer;
    }
    public void TotalPrice(bool livesInUSA)
    {
        bool local = livesInUSA;
        int shippingCost = 5;
        
        if(local == true)
        {
            shippingCost = 5;
        }
        else if(local == false)
        {
            shippingCost = 35;
        }
        int totalprice = _prices.Sum() + shippingCost;
        Console.WriteLine($"Total Price: ${totalprice}");
    }
    public void PackingLabel()
    {
        foreach(string product in _products)
        {
            Console.WriteLine(product);
        }
    }
    public string ShippingLabel()
    {
        return GetCustomer();
    }
}