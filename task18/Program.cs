﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти в диапозоне от 1 до 4 включительно ");
int number = Convert.ToInt32(Console.ReadLine());

string Quater(int num)
{
    if (num == 1) return "Диапазон равен х > 0, у > 0 ";
    if (num == 2) return "Диапазон равен х < 0, у > 0 ";
    if (num == 3) return "Диапазон равен х < 0, у > 0 ";
    if (num == 4) return "Диапазон равен х > 0, у < 0 ";
    return "Введите верный номр четверти";
}

// string result = Quater(number);
// Console.WriteLine(result);

// Math.Pow(2, 10);
// double num = Math.Sqrt(10); 
// // 5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
