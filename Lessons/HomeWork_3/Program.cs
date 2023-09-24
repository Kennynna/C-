
Console.WriteLine($" Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введите число A: ");
        int A = Int32.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int B = Int32.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < B; i++)
        {
            result *= A;
        }
        Console.WriteLine($"{A} -> {result}");



    
   Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int originalNumber = number;

        while (number != 0) 
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine($"Сумма цифр числа {originalNumber} равна: {sum}");



        int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };

        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");



