// 1. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//    Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    5 2 6 7
//    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrix(int[,] matr)
{
    Random n_new = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = n_new.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MinSumRow(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[] amount = new int[row];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            amount[i] += array[i, j];
        }
    }
    return amount;
}

void InputRow(int[] minimal)
{   
    int min = minimal[0];
    int col = 0;
    for (int i = 0; i < minimal.Length; i++)
    {
        if (minimal[i] < min)
        {
            min = minimal[i];
            col = i;
        }
    }
    Console.Write($"Минимальная сумма = {min} находится в строке №{col + 1}");
}
int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
int[] min = MinSumRow(matrix);
InputRow(min);