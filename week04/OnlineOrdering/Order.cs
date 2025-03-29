using System; 
class Order
{
    private List<Product> _products;
    private Customer _client;
    

    public Order(Customer customer)
    {
        _client = customer;
        _products = new List<Product>();
    }

    public double CalculateTotal()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }
        double shippingCost = _client.LiveInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }


    public string GetPackingLabel()
    {
        string packingLabel = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.Name,-15} (ID: {product.ProductId,5})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_client.Name}\n{_client.GetAddress()}";
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}