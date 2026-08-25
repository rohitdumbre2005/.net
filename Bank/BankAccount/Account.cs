namespace Bank;

public class BankAccount{

    public int AccountId{get; set;}
    public decimal Balance{get; set;}
    public string Holdername{get; set;}

    public BankAccount(int accountId, decimal balance,string holdername)
    {
        this.AccountId= accountId;
        this.Balance=balance;
        this.Holdername=holdername;
    }

    public void Deposit(decimal amount)
    {
        if (amount<= 0)
        {
            Console.WriteLine("Deposit amount must be Greater than 0");
            return ;
        }
        Balance += amount;
        
    }

    public int Withdraw(decimal amount)
    {
        if( amount<=0)
        {
            Console.WriteLine("Withdraw amount must be Greater than 0");
            return 0;
        }

        else
        {
            Console.WriteLine("Amount Deposited Successfully!");

        }
        
        
        if(amount > Balance)
        {
            Console.WriteLine("Insufficiant Balance !!");
            return 0 ;
        }
        else{

        Balance -= amount;
        Console.WriteLine("Amount Withdraw Successfully!");  
        }

    return 0;
    }

    public void showbalance()
    {
        Console.WriteLine($"{this.Balance}");
    }

    public string OverrideAccountDetails()
        {
           return( "/"+ AccountId+ " /" + Balance + "/"+ Holdername);
        }

    public void Display()
    {
        Console.WriteLine($"BankAccount :{AccountId}/{Balance}/{Holdername}");
        
    } 

}