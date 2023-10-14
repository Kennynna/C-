using System;
/// <summary>
/// Этот класс отвечающий за создание массива
/// </summary>

public static class ArrayCreator
{
/// <summary>
/// Метод создание массива
/// </summary>
/// <param name="n">колличество элементов</param>
/// <returns>Новый массив</returns>
    public static int[] Create (this int n)
    {
        return new int[n];
    }

    public static string ConvertToString(this int[] array)
    {
        return $"[{String.Join(' ' array)}]"
    }
}