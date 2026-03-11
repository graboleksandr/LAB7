using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Func<double, double> discountCalculator = price => price * 0.95;
        discountCalculator += price => price * 0.90;
        discountCalculator += price => price - 100;

        double finalPrice = 1000;

        Delegate[] discounts = discountCalculator.GetInvocationList();

        foreach (Func<double, double> discount in discounts)
        {
            finalPrice = discount(finalPrice);
            Console.WriteLine($"Проміжна ціна: {finalPrice}");
        }

        Console.WriteLine($"\nФінальна ціна після всіх знижок: {finalPrice}");
    }
}