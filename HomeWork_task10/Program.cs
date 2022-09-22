// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNum(int num)
{
    int firstDigit = (num / 10) % 10;
    return firstDigit;
}

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SecondNum(number);
Console.Write($"{number} -> {result} ");


