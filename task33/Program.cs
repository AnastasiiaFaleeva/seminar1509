// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите заданное число ");
int number = Convert.ToInt32(System.Console.ReadLine());


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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool ChekNumber(int[] array, int arg)
{
    bool chekNumber = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
        {
            chekNumber = true;
            break;
        }
    }
    return chekNumber;
}

int[] arr = CreateArrayRndInt(12, 0, 20);
PrintArray(arr);
bool chekNumber = ChekNumber(arr, number);

if (chekNumber) Console.WriteLine("Yes");
else Console.WriteLine("No");