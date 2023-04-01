using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Online Ordering");

        Console.WriteLine();

        Customer customer1 = new Customer();

        Console.Write("Please type your name: ");
        customer1.SetCustomerName();

        Console.WriteLine("What is your address?");
        Console.WriteLine("Type 1 for USA");
        Console.WriteLine("Type 2 for abroad");
        
        string userChoice = Console.ReadLine();
        customer1.GetCustomerAddress(userChoice);

        Address address1 = new Address();
        Console.Write("Street: ");
        string street = Console.ReadLine();
        
        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State/Porvince: ");
        string state = Console.ReadLine();

        Console.Write("Country: ");
        string country = Console.ReadLine();
        address1.SetAddress(street, city, state, country);

        Console.WriteLine();

        Product product1 = new Product();

        Console.WriteLine("Product Name: ");
        string productName = Console.ReadLine();
        product1.SetName(productName);

        Console.WriteLine("Product ID: ");
        string productID = Console.ReadLine();


    }
}