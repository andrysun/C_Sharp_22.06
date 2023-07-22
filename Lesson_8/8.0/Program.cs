// 0. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк и столбцов");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное и максимальное число матрицы");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[n, m];
Random n_new = new Random();

FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
ChangeRows(matrix);
Console.WriteLine("При перемене строк местами матрица имеет следующий вид:");
PrintMatrix(matrix);

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
    Console.WriteLine("Ваша матрица имеет вид:");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j], 4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        (arr[0, j], arr[arr.GetLength(0) - 1, j]) = (arr[arr.GetLength(0) - 1, j], arr[0, j]);
    }
}