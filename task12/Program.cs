// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

bool Multip(int arg1, int arg2)
{
return arg1 % arg2 ==0;
}

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int rest = number1 % number2;
if(Multip(number1,number2)) Console.WriteLine($"{number1}, {number2} -> кратно");
else Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {rest} ");