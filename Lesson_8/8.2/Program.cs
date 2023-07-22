// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9
//    https://metanit.com/sharp/tutorial/4.9.php

void RandomArray(int[,] array, int from, int to)
{
    Random n_new = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = n_new.Next(from, to + 1);
        }
    }
}

void PrintArray(int[,] matr)
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

int[] FriqDic(int[,] matrix, int to)
{
    int[] friq = new int[to + 1];
    foreach (int i in matrix)
    {
        friq[i] += 1;
    }
    return friq;
}

void PrintStringArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.WriteLine($"Число {i} встречается - {mass[i]} раз");
    }
}

Console.WriteLine("Введите количество строк массива:");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива:");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива:");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива:");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] NewArray = new int[row, col];

RandomArray(NewArray, start, stop);
PrintArray(NewArray);
Console.WriteLine();
int[] new_mass = FriqDic(NewArray, stop);
PrintStringArray(new_mass);