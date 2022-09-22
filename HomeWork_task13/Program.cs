// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int ThirdDigit(int num)
{
    while (num / 1000 > 1)
    {
        int num1 = num / 10;
        num = num1;
    };
    int n = num % 10;
    return n;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number / 100) > 1)
{
    int result = ThirdDigit(number);
    Console.Write($"{number} -> {result} ");
}
else Console.Write($"{number} -> третьей цифры нет");