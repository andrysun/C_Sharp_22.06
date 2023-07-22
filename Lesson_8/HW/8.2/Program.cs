// 2. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
      Например, даны 2 матрицы:
      2 4 | 3 4
      3 2 | 3 3
      Результирующая матрица будет:
      18 20
      15 18
*/

void FillMatrix (int[,] array2D, int from, int to)
{
    Random n_new = new Random ();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = n_new.Next(from, to + 1);
        }
    }
}

void PrintMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multiplication (int[,] arr_1, int[,] arr_2)
{
    int row = arr_1.GetLength(0);
    int col = arr_1.GetLength(1);
    int[,] multi_matrix = new int[row, col];

    if (row != arr_1.GetLength(0) || col != arr_2.GetLength(1)) return multi_matrix;
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            multi_matrix[i,j] = arr_1[i,j] * arr_2[i,j];
    return multi_matrix;
}

Console.Write("Введите количество строк первой матрицы: ");
int n_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int m_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк второй матрицы: ");
int n_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы матрицы: ");
int m_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элементов в матрицах: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов в матрицах: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix_1 = new int[n_1, m_1];
int[,] matrix_2 = new int[n_2, m_2];
FillMatrix(matrix_1, start, stop);
FillMatrix(matrix_2, start, stop);
Console.WriteLine("Получившиеся матрицы имеют вид:");
PrintMatrix(matrix_1);
PrintMatrix(matrix_2);
Console.WriteLine("Получившееся произведение матриц имеет вид:");
int[,] result = Multiplication(matrix_1, matrix_2);
PrintMatrix(result);