// 0. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//    [345, 897, 568, 234] -> 2

void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 1000);
    }
}

void PrintArray(int[] mass)
{
    Console.Write("Массив, заполненный случайными числами - [ "); 
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.Write("]"); 
    Console.WriteLine(); 
}

int PozitiveNums (int[] arr, int size)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер масисва");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
FillArray(array);
PrintArray(array);

int result = PozitiveNums(array, size);

Console.WriteLine($"Количество положительных чисел в массиве - {result}");