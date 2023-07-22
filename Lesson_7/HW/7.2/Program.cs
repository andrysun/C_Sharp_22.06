// 2. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк и столбцов");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
MidArif(matrix);

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine("Ваша матрица");
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

void MidArif(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double midsum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {  
            midsum = midsum + arr[i, j];
        }
        midsum = Math.Round((midsum / m), 2);
        Console.Write($"{midsum}  ");
    }
    Console.WriteLine();
}