// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int count = Convert.ToInt32(Console.ReadLine());

if (count <= 0) Console.WriteLine("Ошибка. Количество чисел не может быть меньше 0, повторите ввод ");

InputNumbers(count);

void InputNumbers(int count)
{
   int x = default;
    while (count > 0)
    {
        Console.WriteLine("Введите число ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a>0) x=x+1;
        count --;
    }
Console.WriteLine($"Количество чисел больше нуля -> {x}");
}

