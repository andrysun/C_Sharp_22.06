// 1. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//    A (3,6,8); B (2,1,-7), -> 15.84
//    A (7,-5, 0); B (1,-1,9) -> 11.53

double VectorLength(int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
{
    return Math.Sqrt(Math.Pow(x_1 - x_2, 2) + Math.Pow(y_1 - y_2, 2) + Math.Pow(z_1 - z_2, 2));
}

int x_a = int.Parse(Console.ReadLine()!);
int y_a = int.Parse(Console.ReadLine()!);
int z_a = int.Parse(Console.ReadLine()!);
int x_b = int.Parse(Console.ReadLine()!);
int y_b = int.Parse(Console.ReadLine()!);
int z_b = int.Parse(Console.ReadLine()!);
double result = VectorLength(x_a, y_a, z_a, x_b, y_b, z_b);

Console.WriteLine($"Vector`s length - {result}");