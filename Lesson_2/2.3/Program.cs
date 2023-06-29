// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void Crat(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
        Console.WriteLine($"Данное число - {num}, кратно и числу 7, и числу 23");
    else
        Console.WriteLine($"Данное число - {num}, не кратно ни числу 7, ни числу 23");
}

int input_num = int.Parse(Console.ReadLine()!);
Crat(input_num);
