using System;

class Programies
{
    static void Main(string[] args)
    {
        //Creating the 1st Order class object

        //Creating the 1st Address class object for the 1st Customer class object
        Address address1 = new Address("One Apple Park Way",  "Cupertino",  "California",  95014,  "USA");
        //Creating the 1st Customer class object which received address1 as a variable
        Customer customer1 = new Customer("Tim Cook", address1);

        //Creating the 1st, 2nd, and 3rd Product class objects for the 1st Order class object
        Product product1 = new Product("Banana", 917090, 0.30, 3);
        Product product2 = new Product("Apple", 223197, 1.15, 2);
        Product product3 = new Product("Watermelon", 870017, 4.49, 1);

        //Creating a list of the 1st, 2nd, and 3rd Product class objects called listProducts
        List<Product> listProducts1 = [product1, product2, product3];
        //Creating the 1st Order class object which received customer1 and listProducts1 as variables
        Order order1 = new Order(customer1, listProducts1);

        //Creating the 2nd Order class object

        //Creating the 2nd Address class object for the 2nd Customer class object
        Address address2 = new Address("416 Maetan 3-Dong",  "Suwon",  "Gyeonggi-Do",  443743,  "South Korea");
        //Creating the 2nd Customer class object which received address2 as a variable
        Customer customer2 = new Customer("Han Jong-hee", address2);

        //Creating the 4th, 5th, and 6th Product class objects for the 2nd Order class object
        Product product4 = new Product("Avocado", 413187, 1.25, 2);
        Product product5 = new Product("Orange", 353382, 1.74, 1);
        Product product6 = new Product("Peach", 027346, 1.54, 3);

        //Creating a list of the 4th, 5th and 6th Product class objects for the 2nd Order class object
        List<Product> listProducts2 = [product4, product5, product6];
        //Creating the 2nd Order class object which received customer2 and listProducts2 as variables
        Order order2 = new Order(customer2, listProducts2);
        
        //Creating a list of the two Order class objects so I can iterate through them
        List<Order> listOrders = [order1, order2];

        //Iterating through the two Order class objects to display their information
        foreach (Order i in listOrders)
        {
            Console.WriteLine($"Order for: {i.GetCustomerName()}");
            Console.WriteLine($"Order cost before shipping: ${Math.Round(i.GetOrderCost(), 2)}");
            Console.WriteLine($"Order cost after shipping: ${Math.Round(i.GetCostPlusShipping(), 2)}");
            Console.WriteLine();
            i.DisplayPackingLabel();
            i.DisplayShippingLabel();
        }
    }
}