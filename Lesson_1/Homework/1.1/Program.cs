// 1. Напишите программу, которая принимает на вход три числа
//    и выдает максимальное из них

Console.WriteLine("Введите три числа: ");
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);
int max = 0;

if (num_1 > max)
{
    max = num_1;
}
if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("Максимальное число: " + max);