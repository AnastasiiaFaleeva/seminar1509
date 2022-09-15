// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите целое число для проверки: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (square == number * number)
{
    Console.WriteLine($"Да {square} является квадратом {number}");
}
else
{
    Console.WriteLine($"Нет {square} не является квадратом {number}");
}