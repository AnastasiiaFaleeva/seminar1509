﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max < number2)
{
    int max = number2;
    if (max < number3)
    {
        int max = number3;
        Console.WriteLine($"Максимальное число {max}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {max}");
    }
}
else if (max < number3);
{
    int max = number3;
    Console.WriteLine($"Максимальное число {max}");
}
else
{
    Console.WriteLine($"Максимальное число {max}");
}