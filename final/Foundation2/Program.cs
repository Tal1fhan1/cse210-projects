using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Park Avenue", "New York City", "New York", "USA");
        address1.AddressLabel();
        address1.InUSA();

        Customer customer1 = new Customer("Jeremy Renner", address1.AddressLabel());
        customer1.LivesInUSA();

        Order order1 = new Order();
        order1.GetProducts();
        order1.GetPrices();
        order1.SetCustomer($"{customer1.GetCustomerName()}\n{customer1.GetAddress()}");
        

        Product product1 = new Product("iPhone 14 Pro Max", "i-4637281723", 1299, 1);
        order1.GetProducts().Add($"{product1.GetProductName()} | {product1.GetProductID()}");
        order1.GetPrices().Add(product1.ComputePrice());

        Product product2 = new Product("MagSafe Charger", "m-5674338294", 199, 2);
        order1.GetProducts().Add($"{product2.GetProductName()} | {product2.GetProductID()}");
        order1.GetPrices().Add(product2.ComputePrice());

        Product product3 = new Product("Apple Watch Pro", "a-6453672801", 899, 1);
        order1.GetProducts().Add($"{product3.GetProductName()} | {product3.GetProductID()}");
        order1.GetPrices().Add(product3.ComputePrice());

        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        order1.PackingLabel();
        Console.WriteLine();
        order1.TotalPrice(customer1.LivesInUSA());
        Console.WriteLine();



        Address address2 = new Address("Tinus de Jongh", "Johannesburg", "Gauteng", "South Africa");
        address2.AddressLabel();
        address2.InUSA();

        Customer customer2 = new Customer("Talifhani Netshiheni", address2.AddressLabel());
        customer2.LivesInUSA();

        Order order2 = new Order();
        order2.GetProducts();
        order2.GetPrices();
        order2.SetCustomer($"{customer2.GetCustomerName()}\n{customer2.GetAddress()}");
        

        Product product4 = new Product("Samsung Galaxy Tab S6 Lite", "s-2344856849", 300, 1);
        order2.GetProducts().Add($"{product4.GetProductName()} | {product4.GetProductID()}");
        order2.GetPrices().Add(product4.ComputePrice());

        Product product5 = new Product("Samsung 128GB SD-card", "s-7563728311", 49, 4);
        order2.GetProducts().Add($"{product5.GetProductName()} | {product5.GetProductID()}");
        order2.GetPrices().Add(product5.ComputePrice());

        Product product6 = new Product("BM-800 Microphone", "b-8947543647", 150, 1);
        order2.GetProducts().Add($"{product6.GetProductName()} | {product6.GetProductID()}");
        order2.GetPrices().Add(product6.ComputePrice());

        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        order2.PackingLabel();
        Console.WriteLine();
        order2.TotalPrice(customer2.LivesInUSA());
    }
}