// 0. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void PrintNumbers(int digit)
{
    if (digit == 0) return;
    PrintNumbers(digit - 1);
    Console.Write($"{digit,4}");
}
PrintNumbers(12);