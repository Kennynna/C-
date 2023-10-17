using System;

public class Answer {
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] arr = new int[n, m];
        int temp = 1;
        arr[0, 0] = temp;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i != 0 && j != 0) // Fixed logical operator
                {
                    temp += k;
                    arr[i, j] = temp;
                }
            }
        }
        return arr;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        int[] position = new int[1] { 0 }; // Changed array size to 1
        if ((rowPosition - 1 > matrix.GetLength(0) - 1) || (columnPosition - 1 > matrix.GetLength(1) - 1)) // Fixed logical operator
        {
            return position;
        }
        else
        {
            position[0] = matrix[rowPosition - 1, columnPosition - 1];
            return position;
        }
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        if (results[0] == 0)
        {
            Console.Write("There is no such index");
        }
        else
        {
            Console.Write($"The number in [{X}, {Y}] is {results[0]}");
        }
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 2;
            y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}