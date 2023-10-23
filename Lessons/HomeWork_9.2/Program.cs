using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 3;
        int result = Akkerman(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");

        m = 3;
        n = 2;
        result = Akkerman(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }

    static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Входные аргументы должны быть неотрицательными числами.");
        }
    }
}