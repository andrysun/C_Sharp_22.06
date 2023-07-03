// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

int number = int.Parse(Console.ReadLine()!);
int count = 1;

if (number == 0)
    Console.WriteLine("1");
if (number > 0)
{
    while (count <= number)
    {
        Console.Write(Math.Pow(count, 2) + " ");
        count++;
    }
}