using Banking;

Account acc123=new Account("3070",10000);
AccountHandler handler = new AccountHandler();
acc123.overbalance += handler.PayIncomeTax;
acc123.Deposit(3000);
acc123.underBalance += handler.BlockAccount;
acc123.Withdraw(5000);
Console.WriteLine($"Account Number: {acc123.AccountNumber}");
Console.WriteLine($"Balance: {acc123.Balance}");
