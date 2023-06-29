// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int Max(int num)
{
    if ((num / 10) > (num % 10))
        return num/10;
    return num%10;
}

int RNum = new Random().Next(10, 100);
int result = Max(RNum);
Console.WriteLine(RNum);
Console.WriteLine(result);
// 12 % 10 -> 2
// 12 / 10 -> 1