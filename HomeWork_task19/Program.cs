// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-ти значное число ");
int number = Convert.ToInt32(Console.ReadLine());

int Polindrom(int num)
{
    int n1 = num % 10;
    int n2 = num / 10 % 10;
    int n3 = num / 100 % 10;
    int n4 = num / 1000 % 10;
    int n5 = num / 10000;
    int res = n1 * 10000 + n2 * 1000 + n3 * 100 + n4 * 10 + n5;
    return res;
}

if(number == Polindrom(number)) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");