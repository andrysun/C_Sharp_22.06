/*
1. Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Summator(int m, int n)
{
    int sum = m;
    if (m == n) return 0;
    else
    {
        m++;
        sum = m + Summator(m, n);
        return sum;
    }
}

void PrintSum(int m, int n)
{
    Console.Write(Summator(m - 1, n));
}
Console.Write("Введите начальное число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Сумма элемментов в заданном диапозоне: ");
PrintSum(M, N);