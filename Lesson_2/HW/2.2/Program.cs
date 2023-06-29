// 2. Напишите программу, которая выводит третью цифру заданного числа
//    или сообщает, что третьей цифры нет.

int Figure_100(int num, int count)
{
    int res = ((num % 100) / 10);
    return res;
}
int Figure_1000(int num, int count)
{
    int res = ((num % 100) / 10);
    return res;
}
int Figure_10000(int num, int count)
{
    int res = ((num % 1000) / 100);
    return res;
}
Console.WriteLine("Введите своё число:");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100)
{
    string str = number.ToString();
    int size = str.Length;
    int result = 0;
    if (size == 3) result = Figure_100(number, size);
    if (size == 4) result = Figure_1000(number, size);
    if (size == 5) result = Figure_10000(number, size);
    Console.WriteLine($"Третья цифра вашего числа: {result}");
}
else
{
    Console.WriteLine("Данное число не имеет 3-ей цифры");
}
/*
    while (number > 999) number /= 10; // number = number / 10
    Console.WriteLine(number % 10);
*/