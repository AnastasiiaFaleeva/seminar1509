// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int QuantityEvenNum(int[] array)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
} 

int[] arr = CreateArrayRndInt(10, 0, 1000);
PrintArray(arr);
int quantityEvenNum = QuantityEvenNum (arr);
Console.WriteLine(quantityEvenNum);