public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() { return _name; }
    public void SetName(string name) { _name = name; }

    public string GetId() { return _id; }
    public void SetId(string id) { _id = id; }

    public float GetPrice() { return _price; }
    public void SetPrice(float price) { _price = price; }

    public int GetQuantity() { return _quantity; }
    public void SetQuantity(int quantity) { _quantity = quantity; }

    public float ComputeTotalPrice()
    {
        return _price * _quantity;
    }
}
