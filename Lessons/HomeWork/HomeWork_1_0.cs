
/*
===================================================================================================
==                                      ДЗ № 1                                                   ==
===================================================================================================

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int number2 = int.Parse(Console.ReadLine());
    if(number1 > number2){
      int max = number1;
      int min = number2;
      Console.WriteLine($"Число {number1} > {number2}");
    } else if(number1 < number2){
      int max = number2;
      int min = number1;
      Console.WriteLine($"Число {number2} > {number1}");
    } else{
        Console.WriteLine($"Числа {number1} = {number2} равны");
    }

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("");
Console.WriteLine("Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите число ");
int numberr1 = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int numberr2 = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int numberr3 = int.Parse(Console.ReadLine());
    if (numberr1 > numberr2 && numberr1> numberr3){
        int max = numberr1;
        Console.WriteLine($" {numberr1} больше чем {numberr2} и {numberr3}");
    } else if(numberr2 > numberr1 && numberr2> numberr3){
        int max = numberr2;
        Console.WriteLine($" {numberr2} больше чем {numberr3} и {numberr1}");
    } else if(numberr3 > numberr1 && numberr3> numberr2){
        int max = numberr3;
        Console.WriteLine($" {numberr3} больше чем {numberr2} и {numberr1}");
    
    } else{
        Console.WriteLine("Все три числа равны");
    }



/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("");
Console.WriteLine("Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Введите число ");
int numm = Convert.ToInt32(Console.ReadLine());
    if(numm % 2 == 0){
        Console.WriteLine($" Число {numm} четное");
    } else{
        Console.WriteLine($" Число {numm} нечетное");
    }


/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8  */
Console.WriteLine("");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
    for( int i=n;i>1; i--){
        if (i % 2==0){
            Console.Write($"{i}, ");
        } 
    }