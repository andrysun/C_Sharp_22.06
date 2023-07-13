// 2. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//    [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray(double[] arr_fill, int from, int to)
{
    for (int i = 0; i < arr_fill.Length; i++)
    {
        arr_fill[i] = Math.Round(new Random().NextDouble() * (to - from) + from, 2);
    }
}

void PrintArray(double[] arr_print)
{
    Console.Write("Массив - [ ");
    for (int i = 0; i < arr_print.Length; i++)
    {
        Console.Write(arr_print[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double dif = Math.Round(max - min, 2);
    Console.WriteLine($"Maximum - {max}, Minimum - {min}");
    Console.WriteLine($"Difference - {dif}");
}

Console.WriteLine("Введите размерность массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числовые рамки от какого числа и до какого числа будут заданы числа в массиве");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = new double[size];
FillArray(mass, start, stop);
PrintArray(mass);
Difference(mass);