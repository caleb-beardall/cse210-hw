using System;
using Microsoft.VisualBasic;

public class Order
{
    private Customer _customer;
    private List<Product> _listProducts;

    public Order(Customer newCustomer, List<Product> listProducts)
    {
        _customer = newCustomer;
        _listProducts = listProducts;
    }

    public string GetCustomerName()
    {
        string customerName = _customer.GetName();
        return customerName;
    }
    
    public double GetOrderCost()
    {
        double orderCost = 0;

        foreach (Product i in _listProducts)
        {
            orderCost = orderCost + i.GetProductCost();
        }

        return orderCost;
    }

    public double GetCostPlusShipping()
    {
        double costPlusShipping = 0;

        int shippingCost = 0;

        if (_customer.IsInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        costPlusShipping = GetOrderCost() + shippingCost;
        return costPlusShipping;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"Packing Label:");

        foreach (Product i in _listProducts)
        {
            Console.WriteLine($"{i.GetProductQuantity()} X {i.GetProductName()}(s) (Product ID: {i.GetProductID()})");
        }
        
        Console.WriteLine();
    }
    
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Shipping Label:");

        Console.WriteLine(_customer.GetAddress());

        Console.WriteLine();
    }
}
