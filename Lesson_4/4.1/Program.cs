// 1. Напишите программу, которая принимает на вход числа
//    и выдает количество цифр в числе.

Console.WriteLine("Введите Число");

int Count(int num)
{
    int result = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        result = i;
    }
    return result;
}

int A = Count(int.Parse(Console.ReadLine()!));
Console.WriteLine(A);