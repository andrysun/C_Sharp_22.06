// 1. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//    [3, 7, 23, 12] -> 19
//    [-4, -6, 89, 6] -> 0

void FillArray(int[] arr_fill)
{
    for (int i = 0; i < arr_fill.Length; i++)
    {
        arr_fill[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] arr_print)
{
    Console.Write("Массив - [ ");
    for (int i = 0; i < arr_print.Length; i++)
    {
        Console.Write(arr_print[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int Amount(int[] array)
{
    int amount = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        amount = amount + array[i];
    }
    return amount;
}

Console.WriteLine("Введите размерность массива");
int size = int.Parse(Console.ReadLine()!);
int[] mass = new int[size];
FillArray(mass);
PrintArray(mass);

int sum = Amount(mass);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");