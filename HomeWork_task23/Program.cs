// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine()); 

void Cub(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.WriteLine($" |{counter,2}|  |{counter * counter * counter,4}| ");
        counter++;
    }
}
if(num>1) Cub(num);
else Console.WriteLine("Введено некоректное значение ");