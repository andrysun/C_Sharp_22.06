// 1. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строк и столбцов");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное и максимальное число матрицы");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[n, m];
Random n_new = new Random();


void FillMatrix(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = n_new.Next(from, to + 1);
        }
    }
}

void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Obmen(int[,] matrix)
{
    if (n != m)
        Console.WriteLine("Не возможно перевернуть");
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)

            {
                (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
            }
        }
    }
}
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
Console.WriteLine();
Obmen(matrix);
PrintMatrix(matrix);