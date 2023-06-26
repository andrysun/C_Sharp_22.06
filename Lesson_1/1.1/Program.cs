// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Write a numbers: ");
string num_str_1 = Console.ReadLine()!;
string num_str_2 = Console.ReadLine()!;

int num_1 = int.Parse(num_str_1)!;
int num_2 = int.Parse(num_str_2)!;

/*
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
*/

if (num_1 / num_2 == num_2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}