class Product
{
    private string _product_id;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string product_id, string name, double price, int quantity){
        _product_id = product_id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string ProductId { get { return _product_id; } }
    public string Name { get { return _name; } }
    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }
}
