BankAccount account1 = new BankAccount(100);
account1.Deposit(50);
Console.WriteLine($"Balance: {account1.Balance}");
account1.Withdraw(30);
Console.WriteLine($"Balance: {account1.Balance}");
account1.Withdraw(500);

Console.WriteLine($"Balance: {account1.Balance}");
public class BankAccount
{
    private double balance;

    public double Balance
    {
        get{return balance;}
       

    }

    public BankAccount(double balance)
    {
        this.balance = balance;
    }


    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance +=amount;
        }
    }
    public void Withdraw(double amount)
    {
        if (amount <= 0)
             Console.WriteLine("Amount must be positive");
        else if (amount > balance)
            Console.WriteLine("Not enough money");
        else
            balance -= amount;
    }

    
}
