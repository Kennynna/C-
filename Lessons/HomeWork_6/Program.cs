using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Задача 41
        Console.Write("Введите количество чисел: ");
        int M = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                count++;
            }    
        }

        Console.WriteLine($"Количество чисел, больших 0: {count}");

        // Задача 43
        Console.Write("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите k2: ");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
}