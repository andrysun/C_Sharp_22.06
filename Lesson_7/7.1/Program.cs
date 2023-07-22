// 1. Задайте двумерный массив. Найдите элементы, у которых
//    обе позиции чётные, и замените эти элементы на их квадраты.

void FillArray(int[,] arr, int from, int to)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(from, to + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Ваша матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SquareOfEven(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] mass = new int[m, n];

Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);

FillArray(mass, start, stop);
PrintArray(mass);
SquareOfEven(mass);
PrintArray(mass);