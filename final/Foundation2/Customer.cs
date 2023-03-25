public class Customer
{
    private string _customerName;
    private string _address;

    public Customer()
    {
    }
    public Customer(string customerName, string address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public bool LivesInUSA()
    {
        bool local = false;
        if(_address.Contains("USA") == true)
        {
            local = true;
        }
        return local;
    }
}