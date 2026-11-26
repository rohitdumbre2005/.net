using System;


public class Product : IComparable<Product>
{
    public int Id{get; set;}
    public string Name{get; set;}
    public double Price {get; set;}

    public Product (int id, string name, double price)
    {
        Id=id;
        Name=name;
        Price= price;
    }

    //IComparable<Product>
    public int CompareTo(Product other)
    {
        return Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Price:{Price}";
    }
}




//IComparer<Product>

public class productNameComparer : IComparer<Product>
{
    public int Compare(Product x , Product y)
    {
        return string.Compare(x.Name,y.Name);
    }
}



public class Program 
{
    public static void Main()
    {
        Console.WriteLine("--------ONLINE SHOPPING STORE---------");
        
    }
}