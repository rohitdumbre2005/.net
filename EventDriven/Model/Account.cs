namespace Banking;

public class Account
{
   public event AccountOperation? overbalance;

   public event AccountOperation? underBalance;

    private string _AccountNumber;
   private decimal _Balance;

   public decimal Balance => _Balance;
   public string AccountNumber => _AccountNumber;


    public Account(string accountNumber, decimal balance)
    {
        _AccountNumber = accountNumber;
        _Balance = balance;
    }


    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }
        _Balance += amount;

        if(_Balance >250000)
         {
        overbalance?.Invoke(this, EventArgs.Empty);
         }

    }


    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be greater than zero.");
        }
        _Balance -= amount;

        if(_Balance >=1000)
        {
            underBalance?.Invoke(this, EventArgs.Empty);
        }
         

}
}


