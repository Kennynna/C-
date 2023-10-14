Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 1000){
    Console.WriteLine("число должно быть трехзначным! ");
} else {
    int number2 = number / 10;
    number2 = number2 % 10;
    Console.WriteLine($"вторая цифра из {number} -> {number2} ");
}

Console.WriteLine(" ");
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num >= 100){
    while (num >=1000){
        num=num / 10;
    }
    num=num % 10; 
    Console.WriteLine($"  третяя цифра  {num} ");
} else if (num < -100){ //условие для возведение отрицательного числа в положительное
    num = num * -1;
     while (num >=1000){
        num=num / 10;
    }
    num=num % 10; 
    Console.WriteLine($"  третяя цифра  {num} ");
} else {
    Console.WriteLine($"нет");
};


Console.WriteLine(" ");
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите число ");
int day = int.Parse(Console.ReadLine());    
if (day == 1){
    Console.WriteLine($"нет");
} else if(day == 2 
        || day == 3
        || day == 4
        || day == 5){
    Console.WriteLine($"нет");
} else if(day == 6
        || day == 7){
    Console.WriteLine($"да");
} else {
    Console.WriteLine($"Введите корректный день");
}


