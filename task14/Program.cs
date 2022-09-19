// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Multip(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (Multip(num)) Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");