using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Action> actions = new List<Action>();

        for (int i = 1; i <= 5; i++)
        {
            int localI = i;
            actions.Add(() => Console.WriteLine(localI));
        }

        foreach (var action in actions)
        {
            action();
        }
    }
}