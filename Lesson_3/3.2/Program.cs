// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.

double VectorLength(int x_1, int y_1, int x_2, int y_2)
{
    return Math.Sqrt(Math.Pow(x_1 - x_2, 2) + Math.Pow(y_1 - y_2, 2));
}
int y_a = int.Parse(Console.ReadLine()!);
int y_b = int.Parse(Console.ReadLine()!);
int x_a = int.Parse(Console.ReadLine()!);
int x_b = int.Parse(Console.ReadLine()!);
double result = VectorLength(x_a, x_b, y_a, y_b);
Console.WriteLine("Length of vector " + result);