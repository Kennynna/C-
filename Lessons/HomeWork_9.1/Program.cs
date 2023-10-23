using System;

class Program
{
    static void Main()
    {
        int M = 1; //Начало промежутка
        int N = 4;// Конец проможутка
        
        int sum = CalculateSum(M, N);
        
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {sum}");
    }
    
    static int CalculateSum(int start, int end)
    {
        int sum = 0;
        
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        
        return sum;
    }
}
