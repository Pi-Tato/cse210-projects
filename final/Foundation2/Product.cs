using System;

public class Product
{
    string _itemName;
    int _id, _quantity;
    float _price;

    public Product(string itemName, int id, float price, int quantity)
    {
        _itemName = itemName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetItemInfo()
    {
        return $"Item: {_itemName} ID: {_id} Price: ${_price} Quantity: {_quantity}";
    }

    public float GetTotal()
    {
        return _price * _quantity;
    }
}