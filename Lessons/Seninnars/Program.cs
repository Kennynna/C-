
using System.Text.RegularExpressions;
using Internal;
using System;
/*
===================================================================================================
==                                      1.0     Знакмоство с C#                                     ==
===================================================================================================
*/

/*
переменные как int
Console.write() 
Функция Parse () разрешает переводить строку, которая состоит из цифр, в целое число. 
Console.Write("Введите число "); ввод для терминала
Console.Read() — чтение строки
Console.ReadLine() — чтение строки с переходом на новую строку
Console.Write() — вывод данных
Console.WriteLine() — вывод данных с переходом на новую строку
*/
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()); // Преорбразование строки в число
int str = number * number;

//Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine(""); // Для пустого текста чтобы не слиплось

//Вывод с использованием $
Console.WriteLine($"Квадрат числа {number} = {str}");
//Вывод с переменными
Console.WriteLine("Квадрат числа {0} равен {1}", number,str);
//Вывод с использованием библиоетки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Match.Pow(sqr,2) // Функция которая возводит число в степень через запятую
Console.WriteLine("Квадрат числа {0} равен {1}", sqr,sqr_2);
