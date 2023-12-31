﻿using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
// Введите свое решение ниже
       int sum = 0;
        int numCols = matrix.GetLength(1);

        for (int j = 0; j < numCols; j++)
        {
            sum += matrix[row, j];
        }

        return sum;

    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
// Введите свое решение ниже
       int numRows = matrix.GetLength(0);
        if (numRows == 0)
        {
            throw new ArgumentException("Матрица пуста.");
        }

        int minSum = SumOfRow(matrix, 0);
        int minSumRow = 0;

        for (int i = 1; i < numRows; i++)
        {
            int currentSum = SumOfRow(matrix, i);
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        int[] result = { minSumRow, minSum };
        return result;

    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
    }
}