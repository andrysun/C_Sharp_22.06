// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

void PrintArray(int[] printing)
{
    for (int i = 0; i < printing.Length; i++)
    {
        Console.Write(printing[i] + " ");
    }
}
void FillArray(int[] filling)
{
    for (int i = 0; i < filling.Length; i++)
    {
        filling[i] = new Random().Next(-9, 10);
    }
}
void PositiveNegative(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) pos += arr[i];
        else neg += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of positive numbers -> {pos}; Sum of negative numbers -> {neg}");
}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
PositiveNegative(array);