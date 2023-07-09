// 0. Напишите программу, которая принимает на вход число (А)
//    и выдаёт сумму чисел от 1 до A.

int SumNum(int number)
{
    int all_sum = 0;
    for (int i = 1; i <= number; i++)
        all_sum += i;

    return all_sum;
}

int num = int.Parse(Console.ReadLine()!);
int result = SumNum(num);
Console.WriteLine($"{num} -> {result}");