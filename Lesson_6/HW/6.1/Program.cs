// 1. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//    y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double ba, double ka, double bb, double kb)
{
    double x = 0;
    double y = 0;
    if ((ka - kb) != 0)
    {
        x = Math.Round((bb - ba) / (ka - kb), 2);
        y = Math.Round(((ka * x) + ba), 2);
        Console.WriteLine($"Прямые пересекаются в точке - ({x};{y})");
    }
    else Console.WriteLine("Прямые не пересекаются");
}

Console.WriteLine("Введите значения переменных: b1, k1, b2, k2");
double b1 = int.Parse(Console.ReadLine()!);
double k1 = int.Parse(Console.ReadLine()!);
double b2 = int.Parse(Console.ReadLine()!);
double k2 = int.Parse(Console.ReadLine()!);
Intersection(b1, k1, b2, k2);