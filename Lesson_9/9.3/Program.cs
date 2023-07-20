// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите число основания степени: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(DegreeDigit(a, b));

int DegreeDigit(int A, int B)
{
    if (B == 0) return 1;
    return DegreeDigit(A, B - 1) * A;
}