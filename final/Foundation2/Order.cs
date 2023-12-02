using System.Collections.Generic;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;
    private float _shippingCost;

    public Order(List<Product> productList, Customer customer, float shippingCost)
    {
        _productList = productList;
        _customer = customer;
        _shippingCost = shippingCost;
    }

    public List<Product> GetProductList() { return _productList; }
    public void SetProductList(List<Product> productList) { _productList = productList; }

    public Customer GetCustomer() { return _customer; }
    public void SetCustomer(Customer customer) { _customer = customer; }

    public float GetShippingCost() { return _shippingCost; }
    public void SetShippingCost(float shippingCost) { _shippingCost = shippingCost; }

    public float ComputeBilling()
    {
        float total = 0;
        foreach (Product product in _productList)
        {
            total += product.ComputeTotalPrice();
        }
        return total + _shippingCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productList)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress:\n{_customer.GetAddress().JoinAllFields()}";
    }
}
