// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//    и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите число, которое вы хотите проверить");
int num = int.Parse(Console.ReadLine()!);
SearchNum(matrix, num);

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

void SearchNum(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                Console.WriteLine($"Введенное число находится на {i + 1} строке, в {j + 1} столбце"); 
                return;
            }
        }
    }
    Console.WriteLine("Такого числа в матрице нет");
}