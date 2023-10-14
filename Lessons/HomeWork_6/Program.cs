
// Console.Write($"Введите число А: ");
// int a = int.Parse(Console.ReadLine()); // Parse преобразование в число
// int Sum(int limit)
// {
//     int sum = 0;
//     for(int i = 0; i <= limit; i++)
//     {
//         sum += i;

//     }
//     return sum;
// }
// Console.WriteLine($"Cумма чисел от 1 до {a}  равна {Sum(a)}");

// void Mass(int col)
// {
// int[] arry = new int[col];

// for (int i = 0; i < arry.Length; i++)
// {
//     arry[i] = new Random().Next(0,10);
//     Console.Write($"{arry[i]} ");
// }

// }
// Console.WriteLine("Ввести длину массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// Mass(n);

// void Mass(int col)
// {
// int[] arry = new int[col];

// for (int i = 0; i < arry.Length; i++)
// {
//     arry[i] = new Random().Next(0,1);
//     Console.Write($"{arry[i]} ");
// }

// }
// Console.WriteLine("Ввести длину массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// Mass(n);
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел: ");
        int n = int.Parse(Console.ReadLine()); // Считываем количество чисел

        int count = 0; // Переменная для счетчика

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine()); // Считываем число

            if (number > 0) // Если число больше 0, увеличиваем счетчик
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больших 0: " + count);

        Console.WriteLine("Введите значение переменной b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение переменной k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение переменной b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение переменной k2: ");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
}