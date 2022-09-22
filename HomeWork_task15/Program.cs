// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


bool Week(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите число, которое соответствует дню недели ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 7)
{
    if (Week(number)) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}
else Console.WriteLine($"число {number} не является числом дня недели");