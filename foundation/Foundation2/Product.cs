using System;

public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        string name = _name;
        return name;
    }

    public int GetProductID()
    {
        int productID = _productID;
        return productID;
    }

    public int GetProductQuantity()
    {
        int quantity = _quantity;
        return quantity;
    }
    
    public double GetProductCost()
    {
        double cost = _price * _quantity;
        return cost;
    }
}