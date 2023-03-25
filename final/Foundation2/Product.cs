public class Product
{
    private string _productName;
    private string _productID;
    private int _productPrice;
    private int _productQuantity;

    public Product()
    {
    }
    public Product(string productName, string productID, int productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }
    public int GetProductPrice()
    {
        return _productPrice;
    }
    public void SetProductPrice(int productPrice)
    {
        _productPrice = productPrice;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public void SetProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }

    public int ComputePrice()
    {
        int price = _productPrice * _productQuantity;
        return price;
    }
}