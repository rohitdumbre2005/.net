namespace Banking ;

public class AccountHandler
{
    public void PayIncomeTax(object? sender,EventArgs e)
    {
        Console.WriteLine("Paying income tax for account");
    }

    public void BlockAccount(object? sender,EventArgs e)
    {
        Console.WriteLine("Block the account");
    }
}

