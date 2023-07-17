// 0. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//    m = 3, n = 4.
//    0,5  7    -2    -0,2
//    1   -3,3  8     -9,9
//    8    7,8  -7,1  9

Console.WriteLine("Введите количество строк и столбцов");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101) / 10.0;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}