
using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<Product> products = new List<Product>();
    static int nextId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Supermarket Menu ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddProduct(); break;
                case "2": ViewProducts(); break;
                case "3": UpdateProduct(); break;
                case "4": DeleteProduct(); break;
                case "5": return;
                default: Console.WriteLine("Invalid option"); break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        products.Add(new Product { Id = nextId++, Name = name, Price = price });
        Console.WriteLine("Product added!");
    }

    static void ViewProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        Console.WriteLine("\n--- Product List ---");
        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}");
        }
    }

    static void UpdateProduct()
    {
        Console.Write("Enter product ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.Find(p => p.Id == id);
        if (product == null)
        {
            Console.WriteLine("Product not found!");
            return;
        }

        Console.Write("Enter new name: ");
        product.Name = Console.ReadLine();
        Console.Write("Enter new price: ");
        product.Price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Product updated!");
    }

    static void DeleteProduct()
    {
        Console.Write("Enter product ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.Find(p => p.Id == id);
        if (product == null)
        {
            Console.WriteLine("Product not found!");
            return;
        }

        products.Remove(product);
        Console.WriteLine("Product deleted!");
    }
}
