// 2. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int AmountDigits(int number)
{
    if (number / 10 == 0) return number;
    return AmountDigits(number / 10) + number % 10;
}

AmountDigits(num);
Console.WriteLine(AmountDigits(num));