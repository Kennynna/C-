﻿using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    {
        int numColsA = matrixA.GetLength(1);
        int numRowsB = matrixB.GetLength(0);

        if (numColsA != numRowsB)
        {
            Console.WriteLine("It is impossible to multiply.");
        }
        else
        {
            int[,] result = MatrixMultiplication(matrixA, matrixB);
            PrintMatrix(result);
        }
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        int numRowsA = matrixA.GetLength(0);
        int numColsA = matrixA.GetLength(1);
        int numColsB = matrixB.GetLength(1);

        int[,] result = new int[numRowsA, numColsB];

        for (int i = 0; i < numRowsA; i++)
        {
            for (int j = 0; j < numColsB; j++)
            {
                int sum = 0;

                for (int k = 0; k < numColsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }

                result[i, j] = sum;
            }
        }

        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
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
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}