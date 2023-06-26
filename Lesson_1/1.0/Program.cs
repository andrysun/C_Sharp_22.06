// 0. Напишите программу, которая на вход принимает число и
//    выдаёт его квадрат (число умноженное на само себя).


Console.WriteLine("Write a number: ");
string num_str = Console.ReadLine()!;

int num = int.Parse(num_str); //переведет строку в число
//int num = int.Parse(Console.ReadLine());

Console.WriteLine(num * num);