using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write($"{matrix[i, j]}\t");
      }
      Console.WriteLine();
    }
  
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
        int[,] arr = new int[n, m];
      int temp = 1;
      arr[0, 0] = temp;
      for(int i = 0; i < arr.GetLength(0); i++)
      {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
          if(i != 0 || j != 0)
          {
            temp += k;
            arr[i, j] = temp;
          }
        }
      }
      return arr;

    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("The averages in columns are:");
      for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:f2}\t");
    }

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
        double[] arr = new double[matrix.GetLength(1)];
      double temp = 0;
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
          temp += matrix[i, j];
        }
        arr[j] = temp / matrix.GetLength(0);
        temp = 0;
      }
      return arr;

    }


    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}