// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

void Quarters(int quater)
{
    if (quater > 4 || quater < 1)
        Console.WriteLine("Error");
    else if (quater == 1)
        Console.WriteLine("x > 0 и y > 0");
    else if (quater == 2)
        Console.WriteLine("x < 0 и y > 0");
    else if (quater == 3)
        Console.WriteLine("x < 0 и y < 0");
    else if (quater == 4)
        Console.WriteLine("x > 0 и y < 0");
}

int num_quarter = int.Parse(Console.ReadLine()!);
Quarters(num_quarter);