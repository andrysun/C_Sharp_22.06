// 1. Напишите программу, которая выводит случайное трёхзначное число
//    и удаляет вторую цифру этого числа

void Div(int num_first, int num_second)
{
    Console.Write($"Получившееся число: {num_first}");
    Console.Write(num_second);
}

int number = new Random().Next(100, 1000);
int res_mid = number % 10;
int res = number / 100;
Div(res, res_mid);

Console.Write(" Из числа: ");
Console.Write(number);