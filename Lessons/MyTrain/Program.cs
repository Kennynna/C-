﻿// Напишите программу для поиска максимального элемента в массиве чисел//
Console.Write("Введите длину массива ");
int size = Int32.Parse(Console.ReadLine()); // Пользователь задает длину массива
int [] arry = new int[size]; // создание пустого массива

for (int i = 0; i < size; i++)//цикл для того чтобы пользователь ввел числа для массива
{
    Console.Write("Введите число массива ");
    arry[i] = Int32.Parse(Console.ReadLine());//когда пользователь будет воодит числа это будет они будут сохранены в виде индекса
}
Console.WriteLine("Созданный массив:");
Console.WriteLine("[" + string.Join(", ", arry) + "]"); //string.Join Для объеденения элементов в строку
int IndexMax = 0;
int Amax = 0;
int sum = 0;
int chet = 0;
for (int i = 0; i < size; i++)//цилк для получения максимального значения
{
    if (arry[i]>Amax)
    {
        Amax = arry[i];//проверка на максимальное число
        IndexMax = i;// проверка на максимальный индекс числа
        sum += arry[i];//сумма всех значений индексов
    }
    if(arry[i] % 2 == 0){ //Проверка на четность
            chet += 1;
    }
}
Console.WriteLine($"Максимальный элемент {Amax} а его индекс {IndexMax} а сумма всех эелментов массива {sum} а количество четных {chet}");


