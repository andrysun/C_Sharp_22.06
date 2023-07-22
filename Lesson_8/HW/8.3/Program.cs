// 3. Задайте двумерный массив из целых чисел. 
//    Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void FillMatrix(int[,] array2D, int from, int to)
{
    Random n_new = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = n_new.Next(from, to + 1);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SearchMinimal (int[,] array)
{
    int[] minimal = new int[2];
    minimal[0] = 0;
    minimal[1] = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minimal[0] = i;
                minimal[1] = j;
            }
        }
    }
    Console.WriteLine($"Минимальное значение в матрице - {min}");
    return minimal;
}
void WithoutRowCol (int[,] arr, int[] index)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (index[0] == i || index[1] == j) continue; // перепрыгивает, перейдет к след шагу цикла
            else Console.Write($"{arr[i, j], 4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк матрицы: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элементов в матрице: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов в матрице: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[n, m];
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
int[] res_matr = SearchMinimal(matrix);
Console.WriteLine("На пересечении минимального числа удалился столбец и строка, получившиеся матрица:");
WithoutRowCol(matrix, res_matr);