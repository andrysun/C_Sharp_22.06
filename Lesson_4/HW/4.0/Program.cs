// 0. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//    3, 5 -> 243 (3⁵)
//    2, 4 -> 16

Console.WriteLine("Введите число и затем степень, в которую необходимо возвести ваше число:");
int number = int.Parse(Console.ReadLine()!);
int step = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 1; i <= step; i++)
{
    result = result * number;
}
Console.WriteLine(result);