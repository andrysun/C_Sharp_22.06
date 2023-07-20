// 0. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
      В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
*/

void FillArray(int[,] filling, int from, int to)
{
    Random n_new = new Random();
    for (int i = 0; i < filling.GetLength(0); i++)
    {
        for (int j = 0; j < filling.GetLength(1); j++)
        {
            filling[i, j] = n_new.Next(from, to + 1);
        }
    }
}

void PrintArray(int[,] printing)
{
    Console.WriteLine("Ваша матрица имеет вид:");
    for (int i = 0; i < printing.GetLength(0); i++)
    {
        for (int j = 0; j < printing.GetLength(1); j++)
        {
            Console.Write($"{printing[i, j],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void DecreasingRow(int[,] decreasing)
{
    for (int i = 0; i < decreasing.GetLength(0); i++)
    {
        for (int j = 0; j < decreasing.GetLength(1); j++)
        {
            for (int k = 0; k < decreasing.GetLength(1) - 1; k++)
            {
                if (decreasing[i, k] < decreasing[i, k + 1])
                    (decreasing[i, k], decreasing[i, k + 1]) = (decreasing[i, k + 1], decreasing[i, k]);
            }
        }
    }
}

Console.WriteLine("Введите размерность матрицы. Сначала строки, затем столбцы:");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
int[,] array = new int[n, m];

Console.WriteLine("Введите диапозон чисел [от, до], которые встретятся в матрице:");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

FillArray(array, start, stop);
PrintArray(array);
DecreasingRow(array);
Console.WriteLine("После расстановки элементов строки матрица имеет вид:");
PrintArray(array);