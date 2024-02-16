using System;

public class Order
{
    List<Product> _products = new List<Product>();
    float _shippingCost = 5f;
    string _packingLable, _shippingLable;
    float _totalPrice = 0f;

    Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;

        _shippingLable = _customer.GetInfo();
        _packingLable = _customer.GetInfo();
    }

    public void ShowShippingLabel()
    {
        Console.WriteLine("Shipping label:\n");
        Console.WriteLine($"{_shippingLable}\n");
        foreach (Product item in _products)
        {
            Console.WriteLine($"{item.GetItemInfo()}");
        }
    }
    public void ShowPackingLabel()
    {
        Console.WriteLine("\nPacking label:\n");
        Console.WriteLine($"{_packingLable}\n");
        foreach (Product item in _products)
        {
            _totalPrice += item.GetTotal();

            Console.WriteLine($"{item.GetItemInfo()}");
        }
        if (!_customer.LivesInUSA())
        {
            _shippingCost = 35f;
        }
        Console.WriteLine($"\nSubtotal price: ${_totalPrice}");
        Console.WriteLine($"Shipping cost: ${_shippingCost}");
        Console.WriteLine($"Total price: ${_totalPrice + _shippingCost}\n");
    }
}