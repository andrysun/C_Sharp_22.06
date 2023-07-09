// 1. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//    452 -> 11
//    82 -> 10
//    9012 -> 12

int Count(int num) // подсчёт цифр в числе
{
    int result = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        result = i;
    }
    return result;
}

int number = int.Parse(Console.ReadLine()!);
int count_of_digit = Count(number);
Console.WriteLine($"Количество разрядов: {count_of_digit}");

int sum = 0;
for (int i = 0; i < count_of_digit; i++)
{
    sum = sum + (number % 10);
    number /= 10;
}
Console.WriteLine($"Сумма цифр в числе: {sum}");