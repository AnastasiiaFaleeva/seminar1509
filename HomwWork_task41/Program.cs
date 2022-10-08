// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int count = Convert.ToInt32(Console.ReadLine());

// if (count <= 0) Console.WriteLine("Ошибка. Количество чисел не может быть меньше 0, повторите ввод ");
// int count1 = Convert.ToInt32(Console.ReadLine());

InputNumbers(count);


void InputNumbers(int count)
{
    while (count > 0)
    {
        Console.WriteLine("Введите число ");
        int a = Convert.ToInt32(Console.ReadLine());
        int num1 = a;
        count --;
        num1++;
    }
}

