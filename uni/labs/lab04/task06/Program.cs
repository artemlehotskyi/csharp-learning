using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

double balance = double.Parse(Console.ReadLine()!);
double deposit = double.Parse(Console.ReadLine()!);
double withdraw = double.Parse(Console.ReadLine()!);

BankAccount bankAccount = new BankAccount(balance);

if (bankAccount.Deposit(deposit))
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("FAIL");
}

if (bankAccount.Withdraw(withdraw))
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("FAIL");
}
Console.WriteLine(bankAccount.Balance.ToString(CultureInfo.InvariantCulture));


class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
    }

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public bool Deposit(double deposit)
    {
        if (deposit <= 0)
        {
            return false;
        }
        balance += deposit;
        return true;
    }

    public bool Withdraw(double withdraw)
    {
        if (withdraw > 0 && withdraw <= balance)
        {
            balance -= withdraw;
            return true;
        }
        return false;
    }
}