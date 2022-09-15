// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое цисло: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат чисел {number} = {square}");
// -2 147 438 648 до 2 147 438 647