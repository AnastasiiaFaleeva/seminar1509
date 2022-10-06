// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultiplikateFirstLastNum(int[] array)
{
    int lengthNewArray = default;
    if (array.Length % 2 == 0) lengthNewArray = array.Length / 2;
    else lengthNewArray = (array.Length / 2) + 1;
    int[] newArray = new int[lengthNewArray];
    
    for (int i = 0; i < newArray.Length; i++) //[1, 4, 5, 2, 3]
    {
        newArray[i] = array[i] * array[array.Length - 1 - i]; // [3, 8, 25]
    }

    if (array.Length % 2 == 1) newArray[newArray.Length-1] = array [array.Length /2]; // 25 == 5 мы берем последний элемент нового массива и переписываем его значение
    return newArray;
}

int[] arr = CreateArrayRndInt(11, 1, 10);
PrintArray(arr);
int[] multiplikateFirstLastNum = MultiplikateFirstLastNum(arr);
PrintArray(multiplikateFirstLastNum);