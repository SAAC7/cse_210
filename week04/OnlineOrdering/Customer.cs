using System; 
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }
    public string Name { get { return _name;}}
    // public Address Address { get { return _address;}}
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
    public bool LiveInUSA()
    {
        return _address.IsInUSA();
    }
}