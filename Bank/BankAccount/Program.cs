using System.Runtime;
using System.Security.Cryptography;
using Bank;

public class Account
{
    public static void Main(String[]args)
    {
        Console.Write("Enter Type Of Account: ");
        string accountType = Console.ReadLine()!;

        if (accountType == "Saving")
        {
            Console.WriteLine("Saving Account Selected");
        }

        if (accountType == "Current")
        {
            Console.WriteLine("Current Account Selected");
            
        }

        Console.Write("Enter Your AccountId: ");
        int accountId = int.Parse(Console.ReadLine()!);
        Console.WriteLine();

        Console.Write("Enter Your Initial Balance: ");
        int balance = int.Parse(Console.ReadLine()!);
        Console.WriteLine();

        Console.WriteLine("Enter Your HolderName");
        string? Holdername=Console.ReadLine();
        Console.WriteLine();
        
        BankAccount acct = new BankAccount( accountId, balance, "holdername");
        
        Console.WriteLine("\nAccount Created Successfully!");

        while(true){
        Console.WriteLine("1. Deposit Amount : ");
        Console.WriteLine("2. Withdraw Amount : ");
        Console.WriteLine("3. Show Balance : ");
        int choice = int.Parse(Console.ReadLine()!);


        switch (choice)
        {
            case 1:
            Console.Write("Enter Your Deposit Amount:");
            decimal deposit = decimal.Parse(Console.ReadLine()!);
            acct.Deposit(deposit);
            break;

            case 2:
            Console.Write("Enter Your Withdraw Amount:");
            decimal withdraw = decimal.Parse(Console.ReadLine()!);
            acct.Withdraw(withdraw);
            break; 
            
            case 3:
            Console.WriteLine("Show Account Balance");
            acct.showbalance();
            break;


            default:
            Console.WriteLine("Invalid choice");
            break;
        } 

        }
        
    }
    
}

