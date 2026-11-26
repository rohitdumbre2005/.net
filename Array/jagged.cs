using System;

public class Product
{
    public int Id;
    public string Name;
    public double Price;

    // Constructor
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
      
        int[][] arr = new int[3][]
        {
            new int[] { 11, 21, 56 },
            new int[] { 2, 5, 6, 7 },
            new int[] { 2, 5 }
        };

      
        Console.WriteLine("INTEGER JAGGED ARRAY");

        foreach (int[] row in arr)
        {
            foreach (int number in row)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nPRODUCT JAGGED ARRAY\n");

  
        Product[][] products = new Product[3][]
        {
            new Product[]
            {
                new Product(101, "Mouse", 500),
                new Product(102, "Keyboard", 800),
                new Product(103, "Monitor", 7000)
            },

            new Product[]
            {
                new Product(104, "Laptop", 55000),
                new Product(105, "Pen Drive", 700),
                new Product(106, "Webcam", 1500),
                new Product(107, "Speaker", 2000)
            },

            new Product[]
            {
                new Product(108, "USB Cable", 300),
                new Product(109, "Charger", 1200)
            }
        };

        int categoryNumber = 1;

        foreach (Product[] row in products)
        {
            Console.WriteLine($"--- Category {categoryNumber} ---");

            foreach (Product product in row)
            {
                Console.WriteLine(
                    $"Id: {product.Id}, " +
                    $"Name: {product.Name}, " +
                    $"Price: ₹{product.Price}"
                );
            }

            Console.WriteLine();

            categoryNumber++;
        }
    }
}