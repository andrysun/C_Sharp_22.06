/* 0. Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

void Print(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) Console.Write($"{m,3}");
    Print(m + 1, n);
}
Console.Write("Введите начальное число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int N = int.Parse(Console.ReadLine()!);
Print(M, N);