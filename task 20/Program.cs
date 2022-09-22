// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите х1 ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2 ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1 ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2 ");
double y2 = Convert.ToInt32(Console.ReadLine());

double Distance(double arg1, double arg2, double arg3, double arg4)
{
    double res1 = arg1 - arg3;
    double res2 = arg2 - arg4;
    double result = Math.Sqrt(Math.Pow(res1, 2) + Math.Pow(res2, 2));
    return result;
}

double res = Math.Round(Distance(x1, x2, y1, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);

