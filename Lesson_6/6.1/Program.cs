// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void Trafalgar(int kat_1, int kat_2, int gip)
{
    if (kat_1 < kat_2 + gip && kat_2 < kat_1 + gip && gip < kat_1 + kat_2)
    {
        Console.WriteLine("Такой треугольник существует");
    }
    else Console.WriteLine("Такой треугольник не существует");
}

Console.WriteLine("Введите 3 стороны треугольника");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
Trafalgar(a, b, c);