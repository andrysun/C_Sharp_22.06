// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fibonachi(int num)
{
    int temp_0 = 0;
    int temp_1 = 1;

    for (int i = 0; i < num; i++)
    {
        Console.WriteLine(temp_0);
        (temp_0, temp_1) = (temp_1, temp_0 + temp_1);
    }
}

int number = int.Parse(Console.ReadLine()!);
Fibonachi(number);