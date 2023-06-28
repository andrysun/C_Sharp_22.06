// 0. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает вторую цифру этого числа

int Procedure(int num)
{
    int res_mid = num % 100;
    int res = res_mid / 10;
    return res;
}

int number = new Random().Next(100, 1000);
int result = Procedure(number); 
Console.WriteLine($"Вторая цифра числа {number} - {result}");