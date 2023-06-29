// 1. Напишите программу, которая выводит случайное трёхзначное число
//    и удаляет вторую цифру этого числа

void Div(int num)
{
    int num_first = num /100;
    int num_end = num % 10;
    string str_first = num_first.ToString();
    string str_end = num_end.ToString();
    Console.Write($"Получившееся число: {str_first + str_end} из числа {num}");

}

int number = new Random().Next(100, 1000);
Div(number);