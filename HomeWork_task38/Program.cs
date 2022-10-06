﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)    // МЕТОД ДЛЯ СОЗДАНИЯ МАССИВА ИЗ СЛУЧАЙНЫХ ЧИСЕЛ
{
    double[] array = new double[size];
    var rnd = new Random();    // Создали переменную для случайных чисел

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 100), 2);
    }
    return array;
}

void PrintArray(double[] array) // МЕТОД ДЛЯ ПЕЧАТИ МАССИВА ИЗ СЛУЧАЙНЫХ ЧИСЕЛ
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]};   ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxNumArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double[] arr = CreateArrayRndInt(10, 0, 100);
PrintArray(arr);
double resalt = Math.Round((MaxNumArray(arr) - MinNumArray(arr)), 2);
Console.WriteLine(resalt);