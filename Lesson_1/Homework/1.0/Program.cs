// 0. Напишите программу, которая на вход принимает два числа
//    и выдает какое число меньше, а какое больше

Console.WriteLine("Введите два числа: ");
int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = int.Parse(Console.ReadLine()!);

int max = number_1;
int min = number_1;

if (number_1 > number_2)
{
    max = number_1;
    min = number_2;
}
else
{
    max = number_2;
    min = number_1;
}
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);

// Поправки: дописать программу - допавить проверку, если два числа одинковы.