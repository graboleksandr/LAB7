using System;

class BankTerminal
{
    public event Action<int> OnMoneyWithdraw;

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

        // Наступні рядки тепер викликатимуть ПОМИЛКИ КОМПІЛЯЦІЇ:
        // terminal.OnMoneyWithdraw = null; 
        // Помилка CS0070: Подія може з'являтися лише в лівій частині += або -= (за винятком випадків використання всередині типу BankTerminal)

        // terminal.OnMoneyWithdraw?.Invoke(1000000); 
        // Помилка CS0070: Подія не може бути викликана безпосередньо ззовні класу.
    }
}