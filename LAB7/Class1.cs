using System;

class BankTerminal
{
    public Action<int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Обробка зняття {amount} грн...");
        OnMoneyWithdraw?.Invoke(amount);
    }
}

class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += (amount) => Console.WriteLine($"Успішно знято: {amount} грн");

        terminal.OnMoneyWithdraw = null;

        terminal.OnMoneyWithdraw?.Invoke(1000000);
    }
}