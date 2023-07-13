// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

void FillArray(int[] filling, int from, int to)
{
    for (int i = 0; i < filling.Length; i++)
    {
        filling[i] = new Random().Next(from, to + 1);
    }
}
void PrintArray(int[] printing)
{
    Console.Write("Array of numbers: [ ");
    for (int i = 0; i < printing.Length; i++)
    {
        Console.Write(printing[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
string CheckNum(int[] massive, int num)
{
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] == num) return "yes";
    }
    return "no";
}
Console.WriteLine("Input size of line with numbers:");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

Console.WriteLine("Input the range of numbers from and to:");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
FillArray(array, start, stop);
PrintArray(array);

Console.WriteLine("Input the num of array and check it:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(CheckNum(array, number));