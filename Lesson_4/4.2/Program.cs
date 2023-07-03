// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int number = int.Parse(Console.ReadLine()!);
int result = Factorial(number);
Console.WriteLine($"{number}! = {result}");