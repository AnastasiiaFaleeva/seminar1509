// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// 99-> цифры равны

// int number = new Random().Next(10, 100);

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine($"Цифры числа {number} равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");


// int maxDegit = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.WriteLine();

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit>secondDigit) return firstDigit;
    // return secondDigit;
    if (IsEqualDigits(firstDigit,secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;

}

bool IsEqualDigits(int num1, num2);
{
    return num1 ==num2;
}

int number = new Random().Next(10, 100);
int maxDegit = MaxDigit(number);
string result = maxDegit > 0 ? maxDegit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");