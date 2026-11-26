using System;
using System.Runtime.CompilerServices;
class Library 
{
    private List<string>books=new List<string>()
    {
        "c# Programming",
        "Java Programming",
        "Python Programming",
        "JavaScript ",
        "C Programming"
    };

    //Indexer
    public string this[int index]
    {
        get
        {
            return books[index];
        }

        set
        {
            books[index]=value;
        }
    }

    public void AddBook(string book)
    {
        books.Add(book);
    }

    public int Count
    {
        get
        {
            return books.Count;
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        Console.WriteLine(library[0]);
        Console.WriteLine(library[4]);
        library[1]="c# Advanced";
        Console.WriteLine(library[1]);
        library[4]="Python Advanced";
        Console.WriteLine(library[4]);

        for (int i = 0 ; i < library.Count; i++)
        {
            Console.WriteLine(library[i]);

        }
    }
}
