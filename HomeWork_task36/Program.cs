﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)    // МЕТОД ДЛЯ СОЗДАНИЯ МАССИВА ИЗ СЛУЧАЙНЫХ ЧИСЕЛ
{
    int[] array = new int[size];
    var rnd = new Random();    // Создали переменную для случайных чисел

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) // МЕТОД ДЛЯ ПЕЧАТИ МАССИВА ИЗ СЛУЧАЙНЫХ ЧИСЕЛ
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumElementUnevenPosition (int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }

    return sum;
}

int[] arr = CreateArrayRndInt(10, 0, 1000);
PrintArray(arr);
int sumElementUnevenPosition = SumElementUnevenPosition(arr);
Console.WriteLine(sumElementUnevenPosition);