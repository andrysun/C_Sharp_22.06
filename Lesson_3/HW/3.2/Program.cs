// 2. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//    3 -> 1, 8, 27
//    5 -> 1, 8, 27, 64, 125

int number = int.Parse(Console.ReadLine()!);
int count = 1;

if (number == 0) Console.WriteLine("1");

if (number > 0)
{
    while (count <= number)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count++;
    }
}
else if (number < 0)
{
    count = 0;
    while (number < count)
    {
        Console.Write(Math.Pow(number, 3) + " ");
        number++;
    }
}