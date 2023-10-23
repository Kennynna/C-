using System;

class Program
{
    static void Main()
    {
        int N = 1; // Задайте значение N здесь

        PrintNumbers(N);
    }

    static void PrintNumbers(int n)
    {
        if (n > 0)
        {
            Console.Write(n + ", ");
            PrintNumbers(n - 1);
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}